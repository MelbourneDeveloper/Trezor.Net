using Hid.Net;
using ProtoBuf;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Manager
{
    /// <summary>
    /// An interface for dealing with the Trezor that works across all platforms
    /// </summary>
    public abstract partial class TrezorManagerBase : IDisposable
    {
        #region Events
        public event EventHandler TrezorConnected;
        #endregion

        #region Enums
        public enum USBTypeEnum
        {
            One,
            Two
        }
        #endregion

        #region Constants
        private const string USBTwoName = "U2F Interface";
        private const int FirstChunkStartIndex = 9;
        private const uint HardeningConstant = 0x80000000;
        #endregion

        #region Fields
        private IHidDevice _TrezorHidDevice;
        private int invalidChunksCounter;
        private readonly EnterPinArgs _EnterPinCallback;
        protected SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private string LogSection = nameof(TrezorManagerBase);
        #endregion

        #region Public Properties
        public USBTypeEnum USBType { get; }
        public Features Features { get; private set; }
        #endregion

        #region Constructor
        public TrezorManagerBase(EnterPinArgs enterPinCallback, IHidDevice trezorHidDevice)
        {
            //TODO: Move this to the point when the Trezor is connected
            if (trezorHidDevice != null)
            {
                trezorHidDevice.Connected += TrezorHidDevice_Connected;
            }

            //USBType Two not currently supported...
            USBType = USBTypeEnum.One;
            _EnterPinCallback = enterPinCallback;
            _TrezorHidDevice = trezorHidDevice;
        }
        #endregion

        #region Event Handlers
        private void TrezorHidDevice_Connected(object sender, EventArgs e)
        {
            Logger.Log("Trezor Hid Device Connected", null, LogSection);
            TrezorConnected?.Invoke(this, new EventArgs());
        }
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
            if (Features == null && !(message is Initialize))
            {
                throw new Exception("The Trezor has not been successfully initialised.");
            }

            await _Lock.WaitAsync();

            try
            {
                var response = await SendMessageAsync(message);

                if (response is PinMatrixRequest pinMatrixRequest)
                {
                    var pin = await _EnterPinCallback.Invoke();
                    var result = await PinMatrixAckAsync(pin);
                    if (result is TReadMessage readMessage)
                    {
                        return readMessage;
                    }
                }
                else if (response is ButtonRequest)
                {
                    var retVal = await ButtonAckAsync();

                    while (retVal is ButtonRequest)
                    {
                        retVal = ButtonAckAsync();
                    }

                    if (retVal is TReadMessage readMessage)
                    {
                        return readMessage;
                    }
                }
                else if (response is TReadMessage readMessage)
                {
                    return readMessage;
                }

                throw new NotImplementedException();
            }
            finally
            {
                _Lock.Release();
            }
        }

        /// <summary>
        /// Check to see if the Trezor is connected to the device
        /// </summary>
        public Task<bool> GetIsConnectedAsync() => _TrezorHidDevice.GetIsConnectedAsync();

        public abstract Task<string> GetAddressAsync(string coinShortcut, uint coinNumber, bool isChange, uint index, bool showDisplay, AddressType addressType);

        /// <summary>
        /// Get the Trezor's public key at the specified index.
        /// </summary>
        public async Task<PublicKey> GetPublicKeyAsync(string coinShortcut, uint addressNumber)
        {
            return await SendMessageAsync<PublicKey, GetPublicKey>(new GetPublicKey { CoinName = GetCoinType(coinShortcut).CoinName, AddressNs = new[] { addressNumber } });
        }

        /// <summary>
        /// Initialize the Trezor. Should only be called once.
        /// </summary>
        public async Task InitializeAsync()
        {
            Features = await SendMessageAsync<Features, Initialize>(new Initialize());

            if (Features == null)
            {
                throw new Exception("Error initializing Trezor. Features were not retrieved");
            }
        }

        public void Dispose()
        {
            _TrezorHidDevice?.Dispose();
        }

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
                await _TrezorHidDevice.WriteAsync(range);
            }
        }

        private async Task<object> ReadAsync()
        {
            //Read a chunk
            var readBuffer = await _TrezorHidDevice.ReadAsync();
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

            invalidChunksCounter = 0;

            while (remainingDataLength > 0)
            {
                //Read a chunk
                readBuffer = await _TrezorHidDevice.ReadAsync();

                //check that there was some data returned
                if (readBuffer.Length <= 0)
                {
                    continue;
                }

                //Check what's smaller, the buffer or the remaining data length
                length = Math.Min(readBuffer.Length, remainingDataLength);

                if (readBuffer[0] != (byte)'?')
                {
                    if (invalidChunksCounter++ > 5)
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

        #endregion

        #region Protected Methods
        /// <summary>
        /// Warning: This is not thread safe. It should only be used inside the generic version of this method or to call pin related stuff
        /// </summary>
        protected async Task<object> SendMessageAsync(object message)
        {
            await WriteAsync(message);

            var retVal = await ReadAsync();

            if (retVal is Failure failure)
            {
                throw new FailureException<Failure>($"Error sending message to Trezor.\r\n{message.GetType().Name}", failure);
            }

            return retVal;
        }

        protected abstract Task<object> PinMatrixAckAsync(string pin);

        protected abstract Task<object> ButtonAckAsync();

        protected CoinType GetCoinType(string coinShortcut)
        {
            if (Features == null)
            {
                throw new Exception("The Trezor has not been successfully initialised.");
            }

            return Features.Coins.FirstOrDefault(c => c.CoinShortcut == coinShortcut);
        }
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

        public static object Deserialize(MessageType messageType, byte[] data)
        {
            try
            {
                var typeName = $"Trezor.{messageType.ToString().Replace("MessageType", "")}";
                var type = Type.GetType(typeName);
                return Deserialize(type, data);
            }
            catch
            {
                throw new Exception("InvalidProtocolBufferException");
            }
        }
        #endregion

        #region Protected Static Methods
        protected static uint[] GetAddressPath(bool isSegwit, bool isChange, uint index, uint coinnumber)
        {
            return new[] { ((isSegwit ? (uint)49 : 44) | HardeningConstant) >> 0, (coinnumber | HardeningConstant) >> 0, (0 | HardeningConstant) >> 0, isChange ? 1 : (uint)0, index };
        }
        #endregion
    }
}

