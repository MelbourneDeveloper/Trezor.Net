using Hid.Net;
using ProtoBuf;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trezor.Manager
{
    /// <summary>
    /// An interface for dealing with the Trezor that works across all platforms
    /// </summary>
    public class TrezorManager : IDisposable
    {
        #region Enums
        public enum AddressType
        {
            Bitcoin,
            Ethereum,
            NEM
        }
        #endregion

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

        #region Public Constants
        public const ushort TrezorVendorId = 21324;
        public const int TrezorProductId = 1;
        public const string USBOneName = "TREZOR Interface";
        //TODO: This might not be cool.
        private const string LogSection = "Trezor Manager";
        #endregion

        #region Fields
        private IHidDevice _TrezorHidDevice;
        private int invalidChunksCounter;
        private readonly EnterPinArgs _EnterPinCallback;
        #endregion

        #region Public Properties
        public USBTypeEnum USBType { get; }
        public Features Features { get; private set; }
        #endregion

        #region Constructor
        public TrezorManager(EnterPinArgs enterPinCallback, IHidDevice trezorHidDevice)
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

        #region Protected Methods
        protected async Task<object> SendMessage(object message)
        {
            await WriteAsync(message);

            var retVal = await ReadAsync();

            if (retVal is Failure failure)
            {
                throw new FailureException($"Error sending message to Trezor.\r\n{message.GetType().Name}", failure);
            }

            return retVal;
        }

        protected async Task<TReadMessage> SendMessage<TReadMessage>(object message)
        {
            return (TReadMessage)await SendMessage(message);
        }

        private async Task<object> PinMatrixAck(string pin)
        {
            var retVal = await SendMessage(new PinMatrixAck { Pin = pin });

            if (retVal is Failure failure)
            {
                throw new FailureException("PIN Attempt Failed.", failure);
            }

            return retVal;
        }

        private async Task<object> ButtonAck()
        {
            var retVal = await SendMessage(new ButtonAck());

            if (retVal is Failure failure)
            {
                throw new FailureException("PIN Attempt Failed.", failure);
            }

            return retVal;
        }

        #endregion

        #region Public Methods
        public async Task<TReadMessage> SendMessageAsync<TReadMessage, TWriteMessage>(TWriteMessage message)
        {
            if (Features == null)
            {
                throw new Exception("The Trezor has not been successfully initialised.");
            }

            var response = await SendMessage(message);

            if (response is PinMatrixRequest pinMatrixRequest)
            {
                var pin = await _EnterPinCallback.Invoke();
                var result = await PinMatrixAck(pin);
                if (result is TReadMessage readMessage)
                {
                    return readMessage;
                }
            }
            else if (response is ButtonRequest)
            {
                var retVal = await ButtonAck();

                while (retVal is ButtonRequest)
                {
                    retVal = ButtonAck();
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

        public Task<bool> GetIsConnected() => _TrezorHidDevice.GetIsConnectedAsync();


        public async Task<string> GetAddressAsync(string coinShortcut, uint coinNumber, bool isChange, uint index, bool showDisplay, AddressType addressType)
        {
            try
            {
                //ETH and ETC don't appear here so we have to hard code these not to be segwit
                var coinType = Features.Coins.FirstOrDefault(c => c.CoinShortcut.ToLower() == coinShortcut.ToLower());

                var isSegwit = coinType != null && coinType.Segwit;

                var path = GetAddressPath(isSegwit, isChange, index, coinNumber);

                switch (addressType)
                {
                    case AddressType.Bitcoin:

                        return (await SendMessageAsync<Address, GetAddress>(new GetAddress { ShowDisplay = showDisplay, AddressNs = path, CoinName = GetCoinType(coinShortcut)?.CoinName, ScriptType = isSegwit ? InputScriptType.Spendp2shwitness : InputScriptType.Spendaddress })).address;

                    case AddressType.Ethereum:

                        var ethereumAddress = await SendMessageAsync<EthereumAddress, EthereumGetAddress>(new EthereumGetAddress { ShowDisplay = showDisplay, AddressNs = path });

                        var sb = new StringBuilder();
                        foreach (var b in ethereumAddress.Address)
                        {
                            sb.Append(b.ToString("X2").ToLower());
                        }

                        var hexString = sb.ToString();

                        return $"0x{hexString}";

                    case AddressType.NEM:
                        throw new NotImplementedException();
                    default:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error Getting Trezor Address", ex, LogSection);
                throw;
            }
        }

        public async Task<PublicKey> GetPublicKeyAsync(string coinShortcut, uint addressNumber)
        {
            return await SendMessageAsync<PublicKey, GetPublicKey>(new GetPublicKey { CoinName = GetCoinType(coinShortcut).CoinName, AddressNs = new[] { addressNumber } });
        }

        public async Task InitializeAsync()
        {
            if (Features != null)
            {
                return;
            }

            var retVal = await SendMessage(new Initialize());

            while (retVal is ButtonRequest)
            {
                retVal = ButtonAck();
            }

            Features = retVal as Features;

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
        private CoinType GetCoinType(string coinShortcut)
        {
            if (Features == null)
            {
                throw new Exception("The Trezor has not been successfully initialised.");
            }

            return Features.Coins.FirstOrDefault(c => c.CoinShortcut == coinShortcut);
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

        #region Private Static Methods
        private static uint[] GetAddressPath(bool isSegwit, bool isChange, uint index, uint coinnumber)
        {
            return new[] { ((isSegwit ? (uint)49 : 44) | HardeningConstant) >> 0, (coinnumber | HardeningConstant) >> 0, (0 | HardeningConstant) >> 0, isChange ? 1 : (uint)0, index };
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
    }
}

