using CryptoCurrency.Net.Base.Abstractions.AddressManagement;
using Device.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trezor.Net.Contracts;
using Trezor.Net.Contracts.Bitcoin;
using Trezor.Net.Contracts.Bootloader;
using Trezor.Net.Contracts.Cardano;
using Trezor.Net.Contracts.Common;
using Trezor.Net.Contracts.Crypto;
using Trezor.Net.Contracts.Debug;
using Trezor.Net.Contracts.Ethereum;
using Trezor.Net.Contracts.Lisk;
using Trezor.Net.Contracts.Management;
using Trezor.Net.Contracts.Monero;
using Trezor.Net.Contracts.NEM;
using Trezor.Net.Contracts.Ontology;
using Trezor.Net.Contracts.Ripple;
using Trezor.Net.Contracts.Stellar;
using Trezor.Net.Contracts.Tezos;

namespace Trezor.Net
{
    public class TrezorManager : TrezorManagerBase<MessageType>
    {
        #region Fields
        private bool disposed;
        #endregion

        #region Private Constants
        private const string LogSection = "Trezor Manager";
        #endregion

        #region Public Constants
        public static List<FilterDeviceDefinition> DeviceDefinitions => new List<FilterDeviceDefinition>
        {
            new FilterDeviceDefinition{ DeviceType= DeviceType.Hid, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x", UsagePage=65280 },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x (Android Only)" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C1, Label="Trezor One Firmware 1.7.x +" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C0, Label="Model T" }
        };
        #endregion

        #region Public Properties
        public Features Features { get; private set; }
        #endregion

        #region Public Override Properties
        public override bool IsInitialized => Features != null;
        #endregion

        #region Private Methods
        private void CheckForSupported(string feature)
        {
            if (string.Compare(Features.Model, "T", StringComparison.OrdinalIgnoreCase) != 0)
            {
                throw new NotSupportedException($"{feature} is only supported on the Model T");
            }
        }
        #endregion

        #region Protected Override Properties
        protected override string ContractNamespace => "Trezor.Net.Contracts";
        protected override Type MessageTypeType => typeof(MessageType);
        protected override bool? IsOldFirmware => Features?.MajorVersion < 2 && Features?.MinorVersion < 8;
        #endregion

        #region Constructor
        public TrezorManager(EnterPinArgs enterPinCallback, EnterPinArgs enterPassphraseCallback, IDevice trezorDevice) : this(enterPinCallback, enterPassphraseCallback, trezorDevice, new DefaultCoinUtility())
        {
        }

        public TrezorManager(EnterPinArgs enterPinCallback, EnterPinArgs enterPassphraseCallback, IDevice trezorDevice, ICoinUtility coinUtility) : base(enterPinCallback, enterPassphraseCallback, trezorDevice, coinUtility)
        {
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

        protected override bool IsPassphraseRequest(object response)
        {
            return response is PassphraseRequest;
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

        protected override async Task<object> PassphraseAckAsync(string passPhrase)
        {
            var retVal = await SendMessageAsync(new PassphraseAck { Passphrase = passPhrase });

            if (retVal is Failure failure)
            {
                throw new FailureException<Failure>("Passphrase Attempt Failed.", failure);
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
                throw new ManagerException($"{messageTypeString} is not a valid MessageType");
            }

            return messageType;
        }

#pragma warning disable CA2213, CA1502
        /// <summary>
        /// TODO: Nasty. This at least needs some caching or something...
        /// </summary>
        protected override Type GetContractType(MessageType messageType, string typeName)
        {
            switch (messageType)
            {
                case MessageType.MessageTypeAddress:
                    return typeof(Address);
                case MessageType.MessageTypeGetAddress:
                    return typeof(GetAddress);
                case MessageType.MessageTypeButtonAck:
                    return typeof(ButtonAck);
                case MessageType.MessageTypeButtonRequest:
                    return typeof(ButtonRequest);
                case MessageType.MessageTypePublicKey:
                    return typeof(PublicKey);
                case MessageType.MessageTypeFeatures:
                    return typeof(Features);
                case MessageType.MessageTypePinMatrixAck:
                    return typeof(PinMatrixAck);
                case MessageType.MessageTypePinMatrixRequest:
                    return typeof(PinMatrixRequest);
                case MessageType.MessageTypeApplyFlags:
                    return typeof(ApplyFlags);
                case MessageType.MessageTypeApplySettings:
                    return typeof(ApplySettings);
                case MessageType.MessageTypeBackupDevice:
                    return typeof(BackupDevice);
                case MessageType.MessageTypeCancel:
                    return typeof(Cancel);
                case MessageType.MessageTypeCardanoAddress:
                    return typeof(CardanoAddress);
                case MessageType.MessageTypeCardanoGetAddress:
                    return typeof(CardanoGetAddress);
                case MessageType.MessageTypeCardanoGetPublicKey:
                    return typeof(CardanoGetPublicKey);
                case MessageType.MessageTypeCardanoPublicKey:
                    return typeof(CardanoPublicKey);
                case MessageType.MessageTypeCardanoSignedTx:
                    return typeof(CardanoSignedTx);
                case MessageType.MessageTypeCardanoSignTx:
                    return typeof(CardanoSignTx);
                case MessageType.MessageTypeCardanoTxAck:
                    return typeof(CardanoTxAck);
                case MessageType.MessageTypeCardanoTxRequest:
                    return typeof(CardanoTxRequest);
                case MessageType.MessageTypeStellarCreateAccountOp:
                    return typeof(StellarCreateAccountOp);
                case MessageType.MessageTypeStellarCreatePassiveOfferOp:
                    return typeof(StellarCreatePassiveOfferOp);
                case MessageType.MessageTypeStellarGetAddress:
                    return typeof(StellarGetAddress);
                case MessageType.MessageTypeStellarManageDataOp:
                    return typeof(StellarManageDataOp);
                case MessageType.MessageTypeStellarManageOfferOp:
                    return typeof(StellarManageOfferOp);
                case MessageType.MessageTypeStellarPathPaymentOp:
                    return typeof(StellarPathPaymentOp);
                case MessageType.MessageTypeStellarPaymentOp:
                    return typeof(StellarPaymentOp);
                case MessageType.MessageTypeStellarSetOptionsOp:
                    return typeof(StellarSetOptionsOp);
                case MessageType.MessageTypeStellarSignedTx:
                    return typeof(StellarSignedTx);
                case MessageType.MessageTypeStellarSignTx:
                    return typeof(StellarSignTx);
                case MessageType.MessageTypeStellarTxOpRequest:
                    return typeof(StellarTxOpRequest);
                case MessageType.MessageTypeSuccess:
                    return typeof(Success);
                case MessageType.MessageTypeTezosAddress:
                    return typeof(TezosAddress);
                case MessageType.MessageTypeTezosGetAddress:
                    return typeof(TezosGetAddress);
                case MessageType.MessageTypeTezosGetPublicKey:
                    return typeof(TezosGetPublicKey);
                case MessageType.MessageTypeTezosPublicKey:
                    return typeof(TezosPublicKey);
                case MessageType.MessageTypeTezosSignedTx:
                    return typeof(TezosSignedTx);
                case MessageType.MessageTypeTezosSignTx:
                    return typeof(TezosSignTx);
                case MessageType.MessageTypeTxAck:
                    return typeof(TxAck);
                case MessageType.MessageTypeTxRequest:
                    return typeof(TxRequest);
                case MessageType.MessageTypeVerifyMessage:
                    return typeof(VerifyMessage);
                case MessageType.MessageTypeWipeDevice:
                    return typeof(WipeDevice);
                case MessageType.MessageTypeWordAck:
                    return typeof(WordAck);
                case MessageType.MessageTypeWordRequest:
                    return typeof(WordRequest);
                case MessageType.MessageTypeInitialize:
                    return typeof(Initialize);
                case MessageType.MessageTypePing:
                    return typeof(Ping);
                case MessageType.MessageTypeFailure:
                    return typeof(Failure);
                case MessageType.MessageTypeChangePin:
                    return typeof(ChangePin);
                case MessageType.MessageTypeGetEntropy:
                    return typeof(GetEntropy);
                case MessageType.MessageTypeEntropy:
                    return typeof(Entropy);
                case MessageType.MessageTypeLoadDevice:
                    return typeof(LoadDevice);
                case MessageType.MessageTypeResetDevice:
                    return typeof(ResetDevice);
                case MessageType.MessageTypeClearSession:
                    return typeof(ClearSession);
                case MessageType.MessageTypeEntropyRequest:
                    return typeof(EntropyRequest);
                case MessageType.MessageTypeEntropyAck:
                    return typeof(EntropyAck);
                case MessageType.MessageTypePassphraseRequest:
                    return typeof(PassphraseRequest);
                case MessageType.MessageTypePassphraseAck:
                    return typeof(PassphraseAck);
                case MessageType.MessageTypePassphraseStateRequest:
                    return typeof(PassphraseStateRequest);
                case MessageType.MessageTypePassphraseStateAck:
                    return typeof(PassphraseStateAck);
                case MessageType.MessageTypeRecoveryDevice:
                    return typeof(RecoveryDevice);
                case MessageType.MessageTypeGetFeatures:
                    return typeof(GetFeatures);
                case MessageType.MessageTypeSetU2FCounter:
                    return typeof(SetU2FCounter);
                case MessageType.MessageTypeFirmwareErase:
                    return typeof(FirmwareErase);
                case MessageType.MessageTypeFirmwareUpload:
                    return typeof(FirmwareUpload);
                case MessageType.MessageTypeFirmwareRequest:
                    return typeof(FirmwareRequest);
                case MessageType.MessageTypeSelfTest:
                    return typeof(SelfTest);
                case MessageType.MessageTypeGetPublicKey:
                    return typeof(GetPublicKey);
                case MessageType.MessageTypeSignTx:
                    return typeof(SignTx);
                case MessageType.MessageTypeSignMessage:
                    return typeof(SignMessage);
                case MessageType.MessageTypeMessageSignature:
                    return typeof(MessageSignature);
                case MessageType.MessageTypeCipherKeyValue:
                    return typeof(CipherKeyValue);
                case MessageType.MessageTypeCipheredKeyValue:
                    return typeof(CipheredKeyValue);
                case MessageType.MessageTypeSignIdentity:
                    return typeof(SignIdentity);
                case MessageType.MessageTypeSignedIdentity:
                    return typeof(SignedIdentity);
                case MessageType.MessageTypeGetECDHSessionKey:
                    return typeof(GetECDHSessionKey);
                case MessageType.MessageTypeECDHSessionKey:
                    return typeof(ECDHSessionKey);
                case MessageType.MessageTypeCosiCommit:
                    return typeof(CosiCommit);
                case MessageType.MessageTypeCosiCommitment:
                    return typeof(CosiCommitment);
                case MessageType.MessageTypeCosiSign:
                    return typeof(CosiSign);
                case MessageType.MessageTypeCosiSignature:
                    return typeof(CosiSignature);
                case MessageType.MessageTypeDebugLinkDecision:
                    return typeof(DebugLinkDecision);
                case MessageType.MessageTypeDebugLinkGetState:
                    return typeof(DebugLinkGetState);
                case MessageType.MessageTypeDebugLinkState:
                    return typeof(DebugLinkState);
                case MessageType.MessageTypeDebugLinkStop:
                    return typeof(DebugLinkStop);
                case MessageType.MessageTypeDebugLinkLog:
                    return typeof(DebugLinkLog);
                case MessageType.MessageTypeDebugLinkMemoryRead:
                    return typeof(DebugLinkMemoryRead);
                case MessageType.MessageTypeDebugLinkMemory:
                    return typeof(DebugLinkMemory);
                case MessageType.MessageTypeDebugLinkMemoryWrite:
                    return typeof(DebugLinkMemoryWrite);
                case MessageType.MessageTypeDebugLinkFlashErase:
                    return typeof(DebugLinkFlashErase);
                case MessageType.MessageTypeEthereumGetAddress:
                    return typeof(EthereumGetAddress);
                case MessageType.MessageTypeEthereumAddress:
                    return IsOldFirmware.HasValue && IsOldFirmware.Value ? typeof(Contracts.BackwardsCompatible.EthereumAddress) : typeof(EthereumAddress);
                case MessageType.MessageTypeEthereumSignTx:
                    return typeof(EthereumSignTx);
                case MessageType.MessageTypeEthereumTxRequest:
                    return typeof(EthereumTxRequest);
                case MessageType.MessageTypeEthereumTxAck:
                    return typeof(EthereumTxAck);
                case MessageType.MessageTypeEthereumSignMessage:
                    return typeof(EthereumSignMessage);
                case MessageType.MessageTypeEthereumVerifyMessage:
                    return typeof(EthereumVerifyMessage);
                case MessageType.MessageTypeEthereumMessageSignature:
                    return typeof(EthereumMessageSignature);
                case MessageType.MessageTypeNEMGetAddress:
                    return typeof(NEMGetAddress);
                case MessageType.MessageTypeNEMAddress:
                    return typeof(NEMAddress);
                case MessageType.MessageTypeNEMSignTx:
                    return typeof(NEMSignTx);
                case MessageType.MessageTypeNEMSignedTx:
                    return typeof(NEMSignedTx);
                case MessageType.MessageTypeNEMDecryptMessage:
                    return typeof(NEMDecryptMessage);
                case MessageType.MessageTypeNEMDecryptedMessage:
                    return typeof(NEMDecryptedMessage);
                case MessageType.MessageTypeLiskGetAddress:
                    return typeof(LiskGetAddress);
                case MessageType.MessageTypeLiskAddress:
                    return typeof(LiskAddress);
                case MessageType.MessageTypeLiskSignTx:
                    return typeof(LiskSignTx);
                case MessageType.MessageTypeLiskSignedTx:
                    return typeof(LiskSignedTx);
                case MessageType.MessageTypeLiskSignMessage:
                    return typeof(LiskSignMessage);
                case MessageType.MessageTypeLiskMessageSignature:
                    return typeof(LiskMessageSignature);
                case MessageType.MessageTypeLiskVerifyMessage:
                    return typeof(LiskVerifyMessage);
                case MessageType.MessageTypeLiskGetPublicKey:
                    return typeof(LiskGetPublicKey);
                case MessageType.MessageTypeLiskPublicKey:
                    return typeof(LiskPublicKey);
                case MessageType.MessageTypeStellarAddress:
                    return typeof(StellarAddress);
                case MessageType.MessageTypeStellarChangeTrustOp:
                    return typeof(StellarChangeTrustOp);
                case MessageType.MessageTypeStellarAllowTrustOp:
                    return typeof(StellarAllowTrustOp);
                case MessageType.MessageTypeStellarAccountMergeOp:
                    return typeof(StellarAccountMergeOp);
                case MessageType.MessageTypeStellarBumpSequenceOp:
                    return typeof(StellarBumpSequenceOp);
                case MessageType.MessageTypeOntologyGetAddress:
                    return typeof(OntologyGetAddress);
                case MessageType.MessageTypeOntologyAddress:
                    return typeof(OntologyAddress);
                case MessageType.MessageTypeOntologyGetPublicKey:
                    return typeof(OntologyGetPublicKey);
                case MessageType.MessageTypeOntologyPublicKey:
                    return typeof(OntologyPublicKey);
                case MessageType.MessageTypeOntologySignTransfer:
                    return typeof(OntologySignTransfer);
                case MessageType.MessageTypeOntologySignedTransfer:
                    return typeof(OntologySignedTransfer);
                case MessageType.MessageTypeOntologySignWithdrawOng:
                    return typeof(OntologySignWithdrawOng);
                case MessageType.MessageTypeOntologySignedWithdrawOng:
                    return typeof(OntologySignedWithdrawOng);
                case MessageType.MessageTypeOntologySignOntIdRegister:
                    return typeof(OntologySignOntIdRegister);
                case MessageType.MessageTypeOntologySignedOntIdRegister:
                    return typeof(OntologySignedOntIdRegister);
                case MessageType.MessageTypeOntologySignOntIdAddAttributes:
                    return typeof(OntologySignOntIdAddAttributes);
                case MessageType.MessageTypeOntologySignedOntIdAddAttributes:
                    return typeof(OntologySignedOntIdAddAttributes);
                case MessageType.MessageTypeRippleGetAddress:
                    return typeof(RippleGetAddress);
                case MessageType.MessageTypeRippleAddress:
                    return typeof(RippleAddress);
                case MessageType.MessageTypeRippleSignTx:
                    return typeof(RippleSignTx);
                case MessageType.MessageTypeRippleSignedTx:
                    return typeof(RippleSignedTx);
                case MessageType.MessageTypeMoneroTransactionInitAck:
                    return typeof(MoneroTransactionInitAck);
                case MessageType.MessageTypeMoneroTransactionSetInputAck:
                    return typeof(MoneroTransactionSetInputAck);
                case MessageType.MessageTypeMoneroTransactionInputsPermutationAck:
                    return typeof(MoneroTransactionInputsPermutationAck);
                case MessageType.MessageTypeMoneroTransactionInputViniAck:
                    return typeof(MoneroTransactionInputViniAck);
                case MessageType.MessageTypeMoneroTransactionAllInputsSetAck:
                    return typeof(MoneroTransactionAllInputsSetAck);
                case MessageType.MessageTypeMoneroTransactionSetOutputAck:
                    return typeof(MoneroTransactionSetOutputAck);
                case MessageType.MessageTypeMoneroTransactionAllOutSetAck:
                    return typeof(MoneroTransactionAllOutSetAck);
                case MessageType.MessageTypeMoneroTransactionSignInputAck:
                    return typeof(MoneroTransactionSignInputAck);
                case MessageType.MessageTypeMoneroTransactionFinalAck:
                    return typeof(MoneroTransactionFinalAck);
                case MessageType.MessageTypeMoneroKeyImageExportInitAck:
                    return typeof(MoneroKeyImageExportInitAck);
                case MessageType.MessageTypeMoneroKeyImageSyncStepAck:
                    return typeof(MoneroKeyImageSyncStepAck);
                case MessageType.MessageTypeMoneroKeyImageSyncFinalAck:
                    return typeof(MoneroKeyImageSyncFinalAck);
                case MessageType.MessageTypeMoneroGetAddress:
                    return typeof(MoneroGetAddress);
                case MessageType.MessageTypeMoneroAddress:
                    return typeof(MoneroAddress);
                case MessageType.MessageTypeMoneroGetWatchKey:
                    return typeof(MoneroGetWatchKey);
                case MessageType.MessageTypeMoneroWatchKey:
                    return typeof(MoneroWatchKey);
                case MessageType.MessageTypeDebugMoneroDiagRequest:
                    return typeof(DebugMoneroDiagRequest);
                case MessageType.MessageTypeDebugMoneroDiagAck:
                    return typeof(DebugMoneroDiagAck);
                default:
                    throw new NotImplementedException();
            }
        }
#pragma warning restore CA2213
        #endregion

        #region Public Methods
        public override void Dispose()
        {
            if (disposed) return;
            disposed = true;

            base.Dispose();
        }

        public override Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display)
        {
            if (CoinUtility == null)
            {
                throw new ManagerException($"A {nameof(CoinUtility)} must be specified if {nameof(AddressType)} is not specified.");
            }

            if (addressPath == null) throw new ArgumentNullException(nameof(addressPath));

            var cointType = addressPath.AddressPathElements.Count > 1 ? addressPath.AddressPathElements[1].Value : throw new ManagerException("The first element of the address path is considered to be the coin type. This was not specified so no coin information is available. Please use an overload that specifies CoinInfo.");

            var coinInfo = CoinUtility.GetCoinInfo(cointType);

            return GetAddressAsync(addressPath, isPublicKey, display, coinInfo);
        }

        public Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display, CoinInfo coinInfo)
        {
            if (coinInfo == null) throw new ArgumentNullException(nameof(coinInfo));

            var inputScriptType = coinInfo.IsSegwit ? InputScriptType.Spendp2shwitness : InputScriptType.Spendaddress;

            return GetAddressAsync(addressPath, isPublicKey, display, coinInfo.AddressType, inputScriptType, coinInfo.CoinName);
        }

        public Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display, AddressType addressType, InputScriptType inputScriptType)
        {
            return GetAddressAsync(addressPath, isPublicKey, display, addressType, inputScriptType, null);
        }

        public async Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display, AddressType addressType, InputScriptType inputScriptType, string coinName)
        {
            try
            {
                if (addressPath == null) throw new ArgumentNullException(nameof(addressPath));

                var path = addressPath.ToArray();

                if (isPublicKey)
                {
                    var publicKey = await SendMessageAsync<PublicKey, GetPublicKey>(new GetPublicKey { CoinName = coinName, AddressNs = path, ShowDisplay = display, ScriptType = inputScriptType });
                    return publicKey.Xpub;
                }

                switch (addressType)
                {
                    case AddressType.Bitcoin:

                        //Ultra hack to deal with a coin name change in Firmware Version 1.6.2
                        if (Features.MajorVersion <= 1 && Features.MinorVersion < 6 && string.Equals(coinName, "Bgold", StringComparison.Ordinal))
                        {
                            coinName = "Bitcoin Gold";
                        }

                        return (await SendMessageAsync<Address, GetAddress>(new GetAddress { ShowDisplay = display, AddressNs = path, CoinName = coinName, ScriptType = inputScriptType })).address;

                    case AddressType.Ethereum:

                        var ethereumAddresssds = await SendMessageAsync<object, EthereumGetAddress>(new EthereumGetAddress { ShowDisplay = display, AddressNs = path });

                        switch (ethereumAddresssds)
                        {
                            case EthereumAddress ethereumAddress:
#pragma warning disable CA1304 // Specify CultureInfo
                                return ethereumAddress.Address.ToLower();
#pragma warning restore CA1304 // Specify CultureInfo
                            case Contracts.BackwardsCompatible.EthereumAddress ethereumAddress:

                                //Ouch. Nasty
                                var sb = new StringBuilder();
                                foreach (var b in ethereumAddress.Address)
                                {
#pragma warning disable CA1304 // Specify CultureInfo
#pragma warning disable CA1305 // Specify IFormatProvider
                                    sb.Append(b.ToString("X2").ToLower());
#pragma warning restore CA1305 // Specify IFormatProvider
#pragma warning restore CA1304 // Specify CultureInfo
                                }

                                var hexString = sb.ToString();

                                hexString = $"0x{hexString}";

                                return hexString;
                        }

                        throw new NotImplementedException();



                    case AddressType.Cardano:
                        CheckForSupported(nameof(AddressType.Cardano));
                        return (await SendMessageAsync<CardanoAddress, CardanoGetAddress>(new CardanoGetAddress { ShowDisplay = display, AddressNs = path })).Address;

                    case AddressType.Stellar:
                        return (await SendMessageAsync<StellarAddress, StellarGetAddress>(new StellarGetAddress { ShowDisplay = display, AddressNs = path })).Address;

                    case AddressType.Tezoz:
                        CheckForSupported(nameof(AddressType.Tezoz));
                        return (await SendMessageAsync<TezosAddress, TezosGetAddress>(new TezosGetAddress { ShowDisplay = display, AddressNs = path })).Address;

                    case AddressType.NEM:
                        return (await SendMessageAsync<NEMAddress, NEMGetAddress>(new NEMGetAddress { ShowDisplay = display, AddressNs = path })).Address;

                    default:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                Logger?.Log("Error Getting Trezor Address", LogSection, ex, LogLevel.Error);
                throw;
            }
        }

        /// <summary>
        /// Initialize the Trezor. Should only be called once.
        /// </summary>
        public override async Task InitializeAsync()
        {
            if (disposed) throw new ManagerException("Initialization cannot occur after disposal");

            Features = await SendMessageAsync<Features, Initialize>(new Initialize());

            if (Features == null)
            {
                throw new ManagerException("Error initializing Trezor. Features were not retrieved");
            }
        }
        #endregion
    }
}
