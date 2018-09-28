namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class ButtonRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"code")]
        [System.ComponentModel.DefaultValue(ButtonRequestType.ButtonRequestOther)]
        public ButtonRequestType Code
        {
            get => __pbn__Code ?? ButtonRequestType.ButtonRequestOther;
            set => __pbn__Code = value;
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private ButtonRequestType? __pbn__Code;

        [ProtoBuf.ProtoMember(2, Name = @"data")]
        [System.ComponentModel.DefaultValue("")]
        public string Data
        {
            get => __pbn__Data ?? "";
            set => __pbn__Data = value;
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private string __pbn__Data;

        [ProtoBuf.ProtoContract()]
        public enum ButtonRequestType
        {
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Other")]
            ButtonRequestOther = 1,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FeeOverThreshold")]
            ButtonRequestFeeOverThreshold = 2,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmOutput")]
            ButtonRequestConfirmOutput = 3,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ResetDevice")]
            ButtonRequestResetDevice = 4,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmWord")]
            ButtonRequestConfirmWord = 5,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_WipeDevice")]
            ButtonRequestWipeDevice = 6,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ProtectCall")]
            ButtonRequestProtectCall = 7,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignTx")]
            ButtonRequestSignTx = 8,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FirmwareCheck")]
            ButtonRequestFirmwareCheck = 9,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Address")]
            ButtonRequestAddress = 10,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PublicKey")]
            ButtonRequestPublicKey = 11,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicWordCount")]
            ButtonRequestMnemonicWordCount = 12,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicInput")]
            ButtonRequestMnemonicInput = 13,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PassphraseType")]
            ButtonRequestPassphraseType = 14,
            [ProtoBuf.ProtoEnum(Name = @"ButtonRequest_UnknownDerivationPath")]
            ButtonRequestUnknownDerivationPath = 15,
        }

    }
}