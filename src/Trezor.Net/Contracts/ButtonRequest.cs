namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class ButtonRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        [global::System.ComponentModel.DefaultValue(ButtonRequestType.ButtonRequestOther)]
        public ButtonRequestType Code
        {
            get { return __pbn__Code ?? ButtonRequestType.ButtonRequestOther; }
            set { __pbn__Code = value; }
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private ButtonRequestType? __pbn__Code;

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Data
        {
            get { return __pbn__Data ?? ""; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private string __pbn__Data;

        [global::ProtoBuf.ProtoContract()]
        public enum ButtonRequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Other")]
            ButtonRequestOther = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FeeOverThreshold")]
            ButtonRequestFeeOverThreshold = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmOutput")]
            ButtonRequestConfirmOutput = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ResetDevice")]
            ButtonRequestResetDevice = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ConfirmWord")]
            ButtonRequestConfirmWord = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_WipeDevice")]
            ButtonRequestWipeDevice = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_ProtectCall")]
            ButtonRequestProtectCall = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_SignTx")]
            ButtonRequestSignTx = 8,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_FirmwareCheck")]
            ButtonRequestFirmwareCheck = 9,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_Address")]
            ButtonRequestAddress = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PublicKey")]
            ButtonRequestPublicKey = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicWordCount")]
            ButtonRequestMnemonicWordCount = 12,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_MnemonicInput")]
            ButtonRequestMnemonicInput = 13,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_PassphraseType")]
            ButtonRequestPassphraseType = 14,
            [global::ProtoBuf.ProtoEnum(Name = @"ButtonRequest_UnknownDerivationPath")]
            ButtonRequestUnknownDerivationPath = 15,
        }

    }
}