using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class Failure
    {
        [ProtoMember(1, Name = @"code")]
        [DefaultValue(FailureType.FailureUnexpectedMessage)]
        public FailureType Code
        {
            get => __pbn__Code ?? FailureType.FailureUnexpectedMessage;
            set => __pbn__Code = value;
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private FailureType? __pbn__Code;

        [ProtoMember(2, Name = @"message")]
        [DefaultValue("")]
        public string Message
        {
            get => __pbn__Message ?? "";
            set => __pbn__Message = value;
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

    }
}