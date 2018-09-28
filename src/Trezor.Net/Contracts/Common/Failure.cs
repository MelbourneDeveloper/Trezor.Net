namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class Failure : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"code")]
        [System.ComponentModel.DefaultValue(FailureType.FailureUnexpectedMessage)]
        public FailureType Code
        {
            get => __pbn__Code ?? FailureType.FailureUnexpectedMessage;
            set => __pbn__Code = value;
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private FailureType? __pbn__Code;

        [ProtoBuf.ProtoMember(2, Name = @"message")]
        [System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get => __pbn__Message ?? "";
            set => __pbn__Message = value;
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

        [ProtoBuf.ProtoContract()]
        public enum FailureType
        {
            [ProtoBuf.ProtoEnum(Name = @"Failure_UnexpectedMessage")]
            FailureUnexpectedMessage = 1,
            [ProtoBuf.ProtoEnum(Name = @"Failure_ButtonExpected")]
            FailureButtonExpected = 2,
            [ProtoBuf.ProtoEnum(Name = @"Failure_DataError")]
            FailureDataError = 3,
            [ProtoBuf.ProtoEnum(Name = @"Failure_ActionCancelled")]
            FailureActionCancelled = 4,
            [ProtoBuf.ProtoEnum(Name = @"Failure_PinExpected")]
            FailurePinExpected = 5,
            [ProtoBuf.ProtoEnum(Name = @"Failure_PinCancelled")]
            FailurePinCancelled = 6,
            [ProtoBuf.ProtoEnum(Name = @"Failure_PinInvalid")]
            FailurePinInvalid = 7,
            [ProtoBuf.ProtoEnum(Name = @"Failure_InvalidSignature")]
            FailureInvalidSignature = 8,
            [ProtoBuf.ProtoEnum(Name = @"Failure_ProcessError")]
            FailureProcessError = 9,
            [ProtoBuf.ProtoEnum(Name = @"Failure_NotEnoughFunds")]
            FailureNotEnoughFunds = 10,
            [ProtoBuf.ProtoEnum(Name = @"Failure_NotInitialized")]
            FailureNotInitialized = 11,
            [ProtoBuf.ProtoEnum(Name = @"Failure_PinMismatch")]
            FailurePinMismatch = 12,
            [ProtoBuf.ProtoEnum(Name = @"Failure_FirmwareError")]
            FailureFirmwareError = 99,
        }

    }
}