using Hid.Net;
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
    public abstract partial class TrezorManagerBase : IDisposable
    {
        #region Events
        public event EventHandler Connected;
        #endregion

        #region Enums
        public enum USBTypeEnum
        {
            One,
            Two
        }
        #endregion

        #region Constants
        private const int FirstChunkStartIndex = 9;
        #endregion

        #region Fields
        private readonly IHidDevice _HidDevice;
        private int _InvalidChunksCounter;
        private readonly EnterPinArgs _EnterPinCallback;
        protected SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private readonly string LogSection = nameof(TrezorManagerBase);
        #endregion

        #region Private Static Fields
        private static Assembly[] _Assemblies;
        private static readonly Dictionary<string, Type> _ContractsByName = new Dictionary<string, Type>();
        #endregion

        #region Public Properties
        public USBTypeEnum USBType { get; }
        #endregion

        #region Protected Abstract Properties
        protected abstract bool HasFeatures { get; }
        protected abstract string ContractNamespace { get; }
        #endregion

        #region Constructor
        protected TrezorManagerBase(EnterPinArgs enterPinCallback, IHidDevice hidDevice)
        {
            if (hidDevice == null)
            {
                throw new ArgumentNullException(nameof(hidDevice));
            }

            hidDevice.Connected += HidDevice_Connected;

            USBType = USBTypeEnum.One;
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
        protected abstract bool IsButtonRequest(object response);
        protected abstract bool IsPinMatrixRequest(object response);
        protected abstract bool IsInitialize(object response);

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

                throw new ManagerException("User did not accept the message or pin was entered incorrectly too many times (Note: this library does not have an incorrect pin safety mechanism.)");
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

        public Task<string> GetAddressAsync(string coinShortcut, uint coinNumber, bool isChange, uint index, bool showDisplay, AddressType addressType)
        {
            return GetAddressAsync(coinShortcut, coinNumber, 0, isChange, index, showDisplay, addressType, null);
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
        public abstract Task<string> GetAddressAsync(string coinShortcut, uint coinNumber, uint account, bool isChange, uint index, bool showDisplay, AddressType addressType, bool? isSegwit);

        #endregion

        #region Private Methods
        protected void ValidateInitialization(object message)
        {
            if (!HasFeatures && !IsInitialize(message))
            {
                throw new ManagerException($"The device has not been successfully initialised. Please call {nameof(InitializeAsync)}.");
            }
        }

        private async Task WriteAsync(object msg)
        {
            Logger.Log($"Write: {msg}", null, LogSection);

            var byteArray = Serialize(msg);

            //This confirms that the message data is correct
            // var testMessage = Deserialize(msg.GetType(), byteArray);

            var msgSize = byteArray.Length;
            var msgName = msg.GetType().Name;

            var messageTypeString = "MessageType" + msgName;
            var isValid = Enum.TryParse(messageTypeString, out MessageType messageType);

            if (!isValid)
            {
                throw new Exception($"{messageTypeString} is not a valid MessageType");
            }

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
            for (var i = 0; i < chunks; i++)
            {
                var range = data.GetRange((i * 64) + 1, 64);
                range[0] = (byte)'?';
                await _HidDevice.WriteAsync(range);
            }
        }

        private async Task<object> ReadAsync()
        {
            //Read a chunk
            var readBuffer = await _HidDevice.ReadAsync();
            MessageType messageType;

            //Check to see that this is a valid first chunk 
            if (readBuffer[0] != (byte)'?' || readBuffer[1] != 35 || readBuffer[2] != 35)
            {
                throw new Exception("Bad read");
            }

            //Looks like the message type is at index 4
            var messageTypeInt = readBuffer[4];

            //Get the message type
            if (Enum.IsDefined(typeof(MessageType), (int)messageTypeInt))
            {
                messageType = (MessageType)messageTypeInt;
            }
            else
            {
                throw new Exception($"The number {messageTypeInt} is not a valid MessageType");
            }

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
                allData = Append(allData, GetRange(readBuffer, length - 1, 1));
                remainingDataLength = 0;
            }

            var msg = Deserialize(messageType, allData);

            Logger.Log($"Read: {msg}", null, LogSection);

            return msg;
        }

        private object Deserialize(MessageType messageType, byte[] data)
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
        private static Type GetContractType(MessageType messageType, string typeName)
        {
            Type contractType;

            lock (_ContractsByName)
            {
                if (!_ContractsByName.TryGetValue(typeName, out contractType))
                {
                    contractType = Type.GetType(typeName);

                    if (contractType == null)
                    {
                        if (_Assemblies == null)
                        {
                            _Assemblies = AppDomain.CurrentDomain.GetAssemblies();
                        }

                        foreach (var assembly in _Assemblies)
                        {
                            foreach (var type in assembly.GetTypes())
                            {
                                if (type.FullName == typeName)
                                {
                                    contractType = type;
                                    break;
                                }
                            }
                        }
                    }

                    if (contractType == null)
                    {
                        throw new Exception($"The device returned a message of {messageType}. There was no corresponding contract type at {typeName}");
                    }
                    else
                    {
                        _ContractsByName.Add(typeName, contractType);
                    }
                }
            }

            return contractType;
        }

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

