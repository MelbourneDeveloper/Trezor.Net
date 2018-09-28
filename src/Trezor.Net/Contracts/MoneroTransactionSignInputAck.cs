namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSignInputAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

        [ProtoBuf.ProtoMember(2, Name = @"cout")]
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