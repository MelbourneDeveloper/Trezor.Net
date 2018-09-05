using Hid.Net;
using System;
using System.Text;
using System.Threading.Tasks;
using Trezor.Net.Contracts;

namespace Trezor.Net
{
    public class TrezorManager : TrezorManagerBase
    {
        #region Private Constants
        private const string LogSection = "Trezor Manager";
        #endregion

        #region Public Constants
        public const ushort TrezorVendorId = 21324;
        public const int TrezorProductId = 1;
        public const string USBOneName = "TREZOR Interface";
        #endregion

        #region Public Properties
        public Features Features { get; private set; }
        #endregion

        #region Protected Override Properties
        protected override bool HasFeatures => Features != null;
        protected override string ContractNamespace => "Trezor.Net.Contracts";
        protected override Type MessageTypeType => typeof(MessageType);
        #endregion

        #region Constructor
        public TrezorManager(EnterPinArgs enterPinCallback, IHidDevice trezorHidDevice) : base(enterPinCallback, trezorHidDevice)
        {
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// TODO: Dependency injection
        /// </summary>
        private CoinType GetCoinType(uint coinNumber)
        {
            switch (coinNumber)
            {
                case 0:
                    return new CoinType { CoinName = "Bitcoin", Segwit = true };
                case 60:
                    return new CoinType { CoinName = "Ethereum", Segwit = false };
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Dependency injection
        /// </summary>
        private CoinType GetCoinType(string coinShortcut)
        {
            switch (coinShortcut)
            {
                case "BTC":
                    return new CoinType { CoinName = "Bitcoin", Segwit = true };
                case "ETH":
                    return new CoinType { CoinName = "Ethereum", Segwit = false };

            }

            throw new NotImplementedException();
        }
        #endregion

        #region Protected Override Methods
        protected override bool IsButtonRequest(object response)
        {
            return response is ButtonRequest;
        }

        protected override bool IsPinMatrixRequest(object response)
        {
            return response is PinMatrixRequest;
        }

        protected override bool IsInitialize(object response)
        {
            return response is Initialize;
        }

        protected override async Task<object> PinMatrixAckAsync(string pin)
        {
            var retVal = await SendMessageAsync(new PinMatrixAck { Pin = pin });

            if (retVal is Failure failure)
            {
                throw new FailureException<Failure>("PIN Attempt Failed.", failure);
            }

            return retVal;
        }

        protected override async Task<object> ButtonAckAsync()
        {
            var retVal = await SendMessageAsync(new ButtonAck());

            if (retVal is Failure failure)
            {
                throw new FailureException<Failure>("USer didn't push the button.", failure);
            }

            return retVal;
        }

        //protected CoinType GetCoinType(string coinShortcut)
        //{
        //    if (!HasFeatures)
        //    {
        //        throw new Exception("The Trezor has not been successfully initialised.");
        //    }

        //    return Features.Coins.Find(c => c.CoinShortcut == coinShortcut);
        //}

        protected override void CheckForFailure(object returnMessage)
        {
            if (returnMessage is Failure failure)
            {
                throw new FailureException<Failure>($"Error sending message to Trezor.\r\nCode: {failure.Code} Message: {failure.Message}", failure);
            }
        }

        protected override object GetEnumValue(string messageTypeString)
        {
            var isValid = Enum.TryParse(messageTypeString, out MessageType messageType);
            if (!isValid)
            {
                throw new Exception($"{messageTypeString} is not a valid MessageType");
            }

            return messageType;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Get the Trezor's public key at the specified index.
        /// </summary>
        public Task<PublicKey> GetPublicKeyAsync(string coinShortcut, uint addressNumber)
        {
            return SendMessageAsync<PublicKey, GetPublicKey>(new GetPublicKey { CoinName = GetCoinType(coinShortcut).CoinName, AddressNs = new[] { addressNumber } });
        }
        #endregion

        #region Public Overrides
        /// <summary>
        /// Get an address from the Trezor
        /// //TODO: Move this back down to TrezorManagerBase
        /// </summary>
        public override async Task<string> GetAddressAsync(string coinShortcut, uint coinNumber, uint account, bool isChange, uint index, bool showDisplay, AddressType addressType, bool? isSegwit)
        {
            try
            {
                ValidateInitialization(null);

                //ETH and ETC don't appear here so we have to hard code these not to be segwit
                //var coinType = Features.Coins.Find(c => string.Equals(c.CoinShortcut, coinShortcut, StringComparison.OrdinalIgnoreCase));

                var coinType = GetCoinType(coinNumber);

                if (isSegwit == null)
                {
                    isSegwit = coinType?.Segwit == true;
                }

                var path = ManagerHelpers.GetAddressPath(isSegwit.Value, account, isChange, index, coinNumber);

                switch (addressType)
                {
                    case AddressType.Bitcoin:

                        return (await SendMessageAsync<Address, GetAddress>(new GetAddress { ShowDisplay = showDisplay, AddressNs = path, CoinName = GetCoinType(coinShortcut)?.CoinName, ScriptType = isSegwit.Value ? InputScriptType.Spendp2shwitness : InputScriptType.Spendaddress })).address;

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

        /// <summary>
        /// Initialize the Trezor. Should only be called once.
        /// </summary>
        public override async Task InitializeAsync()
        {
            Features = await SendMessageAsync<Features, Initialize>(new Initialize());

            if (Features == null)
            {
                throw new Exception("Error initializing Trezor. Features were not retrieved");
            }
        }
        #endregion
    }
}
