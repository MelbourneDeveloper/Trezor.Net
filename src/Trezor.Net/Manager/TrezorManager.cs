using Device.Net;
using Hardwarewallets.Net.Model;
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
        #region Private Constants
        private const string LogSection = "Trezor Manager";
        #endregion

        #region Public Constants
        public const ushort TrezorVendorId = 21324;
        public const int TrezorProductId = 1;
        public static List<ushort> AcceptedUsagePages { get; } = new List<ushort> { 65280 };
        #endregion

        #region Public Properties
        public Features Features { get; private set; }
        #endregion

        #region Public Override Properties
        public override bool IsInitialized => Features != null;
        #endregion

        #region Protected Override Properties
        protected override string ContractNamespace => "Trezor.Net.Contracts";
        protected override Type MessageTypeType => typeof(MessageType);
        #endregion

        #region Constructor
        public TrezorManager(EnterPinArgs enterPinCallback, IDevice trezorHidDevice) : this(enterPinCallback, trezorHidDevice, null)
        {
        }

        public TrezorManager(EnterPinArgs enterPinCallback, IDevice trezorHidDevice, ICoinUtility coinUtility) : base(enterPinCallback, trezorHidDevice, coinUtility)
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
                case MessageType.MessageTypeCardanoMessageSignature:
                    return typeof(CardanoMessageSignature);
                case MessageType.MessageTypeCardanoPublicKey:
                    return typeof(CardanoPublicKey);
                case MessageType.MessageTypeCardanoSignedTx:
                    return typeof(CardanoSignedTx);
                case MessageType.MessageTypeCardanoSignMessage:
                    return typeof(CardanoSignMessage);
                case MessageType.MessageTypeCardanoSignTx:
                    return typeof(CardanoSignTx);
                case MessageType.MessageTypeCardanoTxAck:
                    return typeof(CardanoTxAck);
                case MessageType.MessageTypeCardanoTxRequest:
                    return typeof(CardanoTxRequest);
                case MessageType.MessageTypeCardanoVerifyMessage:
                    return typeof(CardanoVerifyMessage);
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
                    return typeof(EthereumAddress);
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
                case MessageType.MessageTypeMoneroTransactionSignRequest:
                    return typeof(MoneroTransactionSignRequest);
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
                case MessageType.MessageTypeMoneroTransactionRangeSigAck:
                    return typeof(MoneroTransactionRangeSigAck);
                case MessageType.MessageTypeMoneroTransactionAllOutSetAck:
                    return typeof(MoneroTransactionAllOutSetAck);
                case MessageType.MessageTypeMoneroTransactionMlsagDoneAck:
                    return typeof(MoneroTransactionMlsagDoneAck);
                case MessageType.MessageTypeMoneroTransactionSignInputAck:
                    return typeof(MoneroTransactionSignInputAck);
                case MessageType.MessageTypeMoneroTransactionFinalAck:
                    return typeof(MoneroTransactionFinalAck);
                case MessageType.MessageTypeMoneroKeyImageSyncRequest:
                    return typeof(MoneroKeyImageSyncRequest);
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
        #endregion

        #region Public Methods
        public override Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display)
        {
            if (CoinUtility == null)
            {
                throw new ManagerException($"A {nameof(CoinUtility)} must be specified if {nameof(AddressType)} is not specified.");
            }

            var cointType = addressPath.AddressPathElements.Count > 1 ? addressPath.AddressPathElements[1].Value : throw new ManagerException("The first element of the address path is considered to be the coin type. This was not specified so no coin information is available. Please use an overload that specifies CoinInfo.");

            var coinInfo = CoinUtility.GetCoinInfo(cointType);

            return GetAddressAsync(addressPath, isPublicKey, display, coinInfo);
        }

        public Task<string> GetAddressAsync(IAddressPath addressPath, bool isPublicKey, bool display, CoinInfo coinInfo)
        {
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
                var path = addressPath.ToArray();

                if (isPublicKey)
                {
                    var publicKey = await SendMessageAsync<PublicKey, GetPublicKey>(new GetPublicKey { CoinName = coinName, AddressNs = path, ShowDisplay = display, ScriptType = inputScriptType });
                    return publicKey.Xpub;
                }
                else
                {
                    switch (addressType)
                    {
                        case AddressType.Bitcoin:

                            //Ultra hack to deal with a coin name change in Firmware Version 1.6.2
                            if ((Features.MajorVersion <= 1 && Features.MinorVersion < 6) && coinName == "Bgold")
                            {
                                coinName = "Bitcoin Gold";
                            }

                            return (await SendMessageAsync<Address, GetAddress>(new GetAddress { ShowDisplay = display, AddressNs = path, CoinName = coinName, ScriptType = inputScriptType })).address;

                        case AddressType.Ethereum:

                            var ethereumAddress = await SendMessageAsync<EthereumAddress, EthereumGetAddress>(new EthereumGetAddress { ShowDisplay = display, AddressNs = path });

                            var sb = new StringBuilder();
                            foreach (var b in ethereumAddress.Address)
                            {
                                sb.Append(b.ToString("X2").ToLower());
                            }

                            var hexString = sb.ToString();

                            return $"0x{hexString}";
                        default:
                            throw new NotImplementedException();
                    }
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
