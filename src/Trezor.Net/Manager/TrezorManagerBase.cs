using Device.Net;
using Hardwarewallets.Net;
using Hardwarewallets.Net.Model;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Net
{
    /// <summary>
    /// An interface for dealing with the Trezor that works across all platforms
    /// </summary>
    public abstract class TrezorManagerBase<TMessageType> : IDisposable, IAddressDeriver
    {
        #region Events
        public event EventHandler Connected;
        #endregion

        #region Constants
        private const int FirstChunkStartIndex = 9;
        #endregion

        #region Fields
        private readonly IDevice _HidDevice;
        private int _InvalidChunksCounter;
        private readonly EnterPinArgs _EnterPinCallback;
        protected SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private readonly string LogSection = "TrezorManagerBase";
        private object _LastWrittenMessage;
        #endregion

        #region Private Static Fields
        private static readonly Assembly[] _Assemblies;
        private static readonly Dictionary<string, Type> _ContractsByName = new Dictionary<string, Type>();
        #endregion

        #region Public Properties
        public ICoinUtility CoinUtility { get; set; }
        #endregion

        #region Public Abstract Properties
        public abstract bool IsInitialized { get; }
        #endregion

        #region Protected Abstract Properties
        protected abstract string ContractNamespace { get; }
        protected abstract Type MessageTypeType { get; }
        #endregion

        #region Constructor
        protected TrezorManagerBase(EnterPinArgs enterPinCallback, IDevice hidDevice) : this(enterPinCallback, hidDevice, null)
        {

        }

        protected TrezorManagerBase(EnterPinArgs enterPinCallback, IDevice hidDevice, ICoinUtility coinUtility)
        {
            CoinUtility = coinUtility;

            if (hidDevice == null)
            {
                throw new ArgumentNullException(nameof(hidDevice));
            }

            hidDevice.Connected += HidDevice_Connected;

            _EnterPinCallback = enterPinCallback;
            _HidDevice = hidDevice;
        }
        #endregion

        #region Event Handlers
        private void HidDevice_Connected(object sender, EventArgs e)
        {
            Logger.Log("Hid Device Connected", null, LogSection);
            Connected?.Invoke(this, new EventArgs());
        }
        #endregion

        #region Protected Abstract Methods
        protected abstract object GetEnumValue(string messageTypeString);
        protected abstract bool IsButtonRequest(object response);
        protected abstract bool IsPinMatrixRequest(object response);
        protected abstract bool IsInitialize(object response);
        protected abstract Type GetContractType(TMessageType messageType, string typeName);
        #endregion

        #region Public Methods
        /// <summary>
        /// Send a message to the Trezor and receive the result
        /// </summary>
        /// <typeparam name="TReadMessage">The message type</typeparam>
        /// <typeparam name="TWriteMessage">The result type</typeparam>
        /// <param name="message">The message</param>
        /// <returns>The result</returns>
        public async Task<TReadMessage> SendMessageAsync<TReadMessage, TWriteMessage>(TWriteMessage message)
        {
            ValidateInitialization(message);

            await _Lock.WaitAsync();

            try
            {
                var response = await SendMessageAsync(message);

                for (var i = 0; i < 10; i++)
                {
                    if (IsPinMatrixRequest(response))
                    {
                        var pin = await _EnterPinCallback.Invoke();
                        response = await PinMatrixAckAsync(pin);
                        if (response is TReadMessage readMessage)
                        {
                            return readMessage;
                        }
                    }

                    else if (IsButtonRequest(response))
                    {
                        response = await ButtonAckAsync();

                        if (response is TReadMessage readMessage)
                        {
                            return readMessage;
                        }
                    }

                    else if (response is TReadMessage readMessage)
                    {
                        return readMessage;
                    }
                }

                throw new ManagerException($"Returned response ({response.GetType().Name})  was of the wrong specified message type ({typeof(TReadMessage).Name}). The user did not accept the message, or pin was entered incorrectly too many times (Note: this library does not have an incorrect pin safety mechanism.)");
            }
            finally
            {
                _Lock.Release();
            }
        }

        /// <summary>
        /// Check to see if the Trezor is connected to the device
        /// </summary>
        public Task<bool> GetIsConnectedAsync()
        {
            return _HidDevice.GetIsConnectedAsync();
        }

        /// <summary>
        /// Initialize the Trezor. Should only be called once.
        /// </summary>
        public abstract Task InitializeAsync();

        public void Dispose()
        {
            _HidDevice?.Dispose();
        }

        #endregion

        #region Public Abstract Methods
        public abstract Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display);
        #endregion

        #region Private Methods
        private async Task WriteAsync(object msg)
        {
            Logger.Log($"Write: {msg}", null, LogSection);

            var byteArray = Serialize(msg);

            //This confirms that the message data is correct
            // var testMessage = Deserialize(msg.GetType(), byteArray);

            var msgSize = byteArray.Length;
            var msgName = msg.GetType().Name;

            var messageTypeString = "MessageType" + msgName;

            var messageType = GetEnumValue(messageTypeString);

            var msgId = (int)messageType;
            var data = new ByteBuffer(msgSize + 1024); // 32768);
            data.Put((byte)'#');
            data.Put((byte)'#');
            data.Put((byte)((msgId >> 8) & 0xFF));
            data.Put((byte)(msgId & 0xFF));
            data.Put((byte)((msgSize >> 24) & 0xFF));
            data.Put((byte)((msgSize >> 16) & 0xFF));
            data.Put((byte)((msgSize >> 8) & 0xFF));
            data.Put((byte)(msgSize & 0xFF));
            data.Put(byteArray);

            while (data.Position % 63 > 0)
            {
                data.Put(0);
            }

            var chunks = data.Position / 63;

            var wholeArray = data.ToArray();

            for (var i = 0; i < chunks; i++)
            {
                var range = new byte[64];
                range[0] = (byte)'?';

                for (var x = 0; x < 63; x++)
                {
                    range[x + 1] = wholeArray[(i * 63) + x];
                }

                await _HidDevice.WriteAsync(range);
            }

            _LastWrittenMessage = msg;
        }

        private async Task<object> ReadAsync()
        {
            //Read a chunk
            var readBuffer = await _HidDevice.ReadAsync();

            //Check to see that this is a valid first chunk 
            var firstByteNot63 = readBuffer[0] != (byte)'?';
            var secondByteNot35 = readBuffer[1] != 35;
            var thirdByteNot35 = readBuffer[2] != 35;
            if (firstByteNot63 || secondByteNot35 || thirdByteNot35)
            {
                var message = $"An error occurred while attempting to read the message from the device. The last written message was a {_LastWrittenMessage?.GetType().Name}. In the first chunk of data ";

                if (firstByteNot63)
                {
                    message += "the first byte was not 63";
                }

                if (secondByteNot35)
                {
                    message += "the second byte was not 35";
                }

                if (thirdByteNot35)
                {
                    message += "the third byte was not 35";
                }

                throw new ReadException(message, readBuffer, _LastWrittenMessage);
            }

            //Looks like the message type is at index 4
            var messageTypeInt = readBuffer[4];

            if (!Enum.IsDefined(MessageTypeType, (int)messageTypeInt))
            {
                throw new Exception($"The number {messageTypeInt} is not a valid MessageType");
            }

            //Get the message type
            var messageTypeValueName = Enum.GetName(MessageTypeType, messageTypeInt);

            var messageType = (TMessageType)Enum.Parse(MessageTypeType, messageTypeValueName);

            //msgLength:= int(binary.BigEndian.Uint32(buf[i + 4 : i + 8]))
            //TODO: Is this correct?
            var remainingDataLength = ((readBuffer[5] & 0xFF) << 24)
                                      + ((readBuffer[6] & 0xFF) << 16)
                                      + ((readBuffer[7] & 0xFF) << 8)
                                      + (readBuffer[8] & 0xFF);

            var length = Math.Min(readBuffer.Length - (FirstChunkStartIndex), remainingDataLength);

            //This is the first chunk so read from 9-64
            var allData = GetRange(readBuffer, FirstChunkStartIndex, length);

            remainingDataLength -= allData.Length;

            _InvalidChunksCounter = 0;

            while (remainingDataLength > 0)
            {
                //Read a chunk
                readBuffer = await _HidDevice.ReadAsync();

                //check that there was some data returned
                if (readBuffer.Length <= 0)
                {
                    continue;
                }

                //Check what's smaller, the buffer or the remaining data length
                length = Math.Min(readBuffer.Length, remainingDataLength);

                if (readBuffer[0] != (byte)'?')
                {
                    if (_InvalidChunksCounter++ > 5)
                    {
                        throw new Exception("messageRead: too many invalid chunks (2)");
                    }
                }

                allData = Append(allData, GetRange(readBuffer, 1, length - 1));

                //Decrement the length of the data to be read
                remainingDataLength -= (length - 1);

                //Super hack! Fix this!
                if (remainingDataLength != 1)
                {
                    continue;
                }

                allData = Append(allData, GetRange(readBuffer, length, 1));
                remainingDataLength = 0;
            }

            var msg = Deserialize(messageType, allData);

            Logger.Log($"Read: {msg}", null, LogSection);

            return msg;
        }

        private object Deserialize(TMessageType messageType, byte[] data)
        {
            try
            {
                var typeName = $"{ContractNamespace}.{messageType.ToString().Replace("MessageType", string.Empty)}";

                var contractType = GetContractType(messageType, typeName);

                return Deserialize(contractType, data);
            }
            catch
            {
                throw new Exception("InvalidProtocolBufferException");
            }
        }
        #endregion

        #region Protected Methods
        protected void ValidateInitialization(object message)
        {
            if (!IsInitialized && !IsInitialize(message))
            {
                throw new ManagerException($"The device has not been successfully initialised. Please call {nameof(InitializeAsync)}.");
            }
        }

        /// <summary>
        /// Warning: This is not thread safe. It should only be used inside the generic version of this method or to call pin related stuff
        /// </summary>
        protected async Task<object> SendMessageAsync(object message)
        {
            await WriteAsync(message);

            var retVal = await ReadAsync();

            CheckForFailure(retVal);

            return retVal;
        }
        #endregion

        #region Protected Abstract Methods
        protected abstract void CheckForFailure(object returnMessage);
        protected abstract Task<object> PinMatrixAckAsync(string pin);
        protected abstract Task<object> ButtonAckAsync();
        #endregion

        #region Private Static Methods
        /// <summary>
        /// Horribly inefficient array thing
        /// </summary>
        /// <returns></returns>
        private static byte[] GetRange(byte[] bytes, int startIndex, int length)
        {
            return bytes.ToList().GetRange(startIndex, length).ToArray();
        }

        private static byte[] Append(byte[] x, byte[] y)
        {
            var z = new byte[x.Length + y.Length];
            x.CopyTo(z, 0);
            y.CopyTo(z, x.Length);
            return z;
        }

        private static byte[] Serialize(object msg)
        {
            using (var writer = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(writer, msg);
                return writer.ToArray();
            }
        }

        private static object Deserialize(Type type, byte[] data)
        {
            using (var writer = new MemoryStream(data))
            {
                return Serializer.NonGeneric.Deserialize(type, writer);
            }
        }
        #endregion
    }
}

