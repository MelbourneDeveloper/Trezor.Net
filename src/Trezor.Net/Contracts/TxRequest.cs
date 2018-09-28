using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class TxRequest
    {
        [ProtoMember(1, Name = @"request_type")]
        [DefaultValue(RequestType.Txinput)]
        public RequestType RequestType
        {
            get => __pbn__RequestType ?? RequestType.Txinput;
            set => __pbn__RequestType = value;
        }
        public bool ShouldSerializeRequestType() => __pbn__RequestType != null;
        public void ResetRequestType() => __pbn__RequestType = null;
        private RequestType? __pbn__RequestType;

        [ProtoMember(2, Name = @"details")]
        public TxRequestDetailsType Details { get; set; }

        [ProtoMember(3, Name = @"serialized")]
        public TxRequestSerializedType Serialized { get; set; }

    }
}