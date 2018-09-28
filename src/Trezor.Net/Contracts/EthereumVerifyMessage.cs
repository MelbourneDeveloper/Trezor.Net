namespace Trezor.Net.Contracts.Ethereum
{
    [global::ProtoBuf.ProtoContract()]
    public class EthereumVerifyMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        public byte[] Address
        {
            get { return __pbn__Address; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private byte[] __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

        [global::ProtoBuf.ProtoMember(3, Name = @"message")]
        public byte[] Message
        {
            get { return __pbn__Message; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private byte[] __pbn__Message;

    }
}