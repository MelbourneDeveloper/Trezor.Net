using ProtoBuf;

namespace Trezor
{
    public enum ButtonRequestType
    {
        [ProtoEnum(Name = @"ButtonRequest_Other")]
        ButtonRequestOther = 1,
        [ProtoEnum(Name = @"ButtonRequest_FeeOverThreshold")]
        ButtonRequestFeeOverThreshold = 2,
        [ProtoEnum(Name = @"ButtonRequest_ConfirmOutput")]
        ButtonRequestConfirmOutput = 3,
        [ProtoEnum(Name = @"ButtonRequest_ResetDevice")]
        ButtonRequestResetDevice = 4,
        [ProtoEnum(Name = @"ButtonRequest_ConfirmWord")]
        ButtonRequestConfirmWord = 5,
        [ProtoEnum(Name = @"ButtonRequest_WipeDevice")]
        ButtonRequestWipeDevice = 6,
        [ProtoEnum(Name = @"ButtonRequest_ProtectCall")]
        ButtonRequestProtectCall = 7,
        [ProtoEnum(Name = @"ButtonRequest_SignTx")]
        ButtonRequestSignTx = 8,
        [ProtoEnum(Name = @"ButtonRequest_FirmwareCheck")]
        ButtonRequestFirmwareCheck = 9,
        [ProtoEnum(Name = @"ButtonRequest_Address")]
        ButtonRequestAddress = 10,
        [ProtoEnum(Name = @"ButtonRequest_PublicKey")]
        ButtonRequestPublicKey = 11
    }
}