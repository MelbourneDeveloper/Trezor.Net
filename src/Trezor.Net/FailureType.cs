using ProtoBuf;

namespace Trezor
{
    public enum FailureType
    {
        [ProtoEnum(Name = @"Failure_UnexpectedMessage")]
        FailureUnexpectedMessage = 1,
        [ProtoEnum(Name = @"Failure_ButtonExpected")]
        FailureButtonExpected = 2,
        [ProtoEnum(Name = @"Failure_DataError")]
        FailureDataError = 3,
        [ProtoEnum(Name = @"Failure_ActionCancelled")]
        FailureActionCancelled = 4,
        [ProtoEnum(Name = @"Failure_PinExpected")]
        FailurePinExpected = 5,
        [ProtoEnum(Name = @"Failure_PinCancelled")]
        FailurePinCancelled = 6,
        [ProtoEnum(Name = @"Failure_PinInvalid")]
        FailurePinInvalid = 7,
        [ProtoEnum(Name = @"Failure_InvalidSignature")]
        FailureInvalidSignature = 8,
        [ProtoEnum(Name = @"Failure_ProcessError")]
        FailureProcessError = 9,
        [ProtoEnum(Name = @"Failure_NotEnoughFunds")]
        FailureNotEnoughFunds = 10,
        [ProtoEnum(Name = @"Failure_NotInitialized")]
        FailureNotInitialized = 11,
        [ProtoEnum(Name = @"Failure_FirmwareError")]
        FailureFirmwareError = 99
    }
}