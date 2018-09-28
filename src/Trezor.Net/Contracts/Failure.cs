namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class Failure : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"code")]
        [global::System.ComponentModel.DefaultValue(FailureType.FailureUnexpectedMessage)]
        public FailureType Code
        {
            get { return __pbn__Code ?? FailureType.FailureUnexpectedMessage; }
            set { __pbn__Code = value; }
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private FailureType? __pbn__Code;

        [global::ProtoBuf.ProtoMember(2, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get { return __pbn__Message ?? ""; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

        [global::ProtoBuf.ProtoContract()]
        public enum FailureType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_UnexpectedMessage")]
            FailureUnexpectedMessage = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ButtonExpected")]
            FailureButtonExpected = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_DataError")]
            FailureDataError = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ActionCancelled")]
            FailureActionCancelled = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinExpected")]
            FailurePinExpected = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinCancelled")]
            FailurePinCancelled = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinInvalid")]
            FailurePinInvalid = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_InvalidSignature")]
            FailureInvalidSignature = 8,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_ProcessError")]
            FailureProcessError = 9,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotEnoughFunds")]
            FailureNotEnoughFunds = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_NotInitialized")]
            FailureNotInitialized = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_PinMismatch")]
            FailurePinMismatch = 12,
            [global::ProtoBuf.ProtoEnum(Name = @"Failure_FirmwareError")]
            FailureFirmwareError = 99,
        }

    }
}