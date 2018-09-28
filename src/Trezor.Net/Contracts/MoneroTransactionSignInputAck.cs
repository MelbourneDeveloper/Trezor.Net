namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionSignInputAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

        [global::ProtoBuf.ProtoMember(2, Name = @"cout")]
        public byte[] Cout
        {
            get { return __pbn__Cout; }
            set { __pbn__Cout = value; }
        }
        public bool ShouldSerializeCout() => __pbn__Cout != null;
        public void ResetCout() => __pbn__Cout = null;
        private byte[] __pbn__Cout;

    }
}