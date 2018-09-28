namespace Trezor.Net.Contracts.Ripple
{
    [ProtoBuf.ProtoContract()]
    public class RippleSignedTx : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"serialized_tx")]
        public byte[] SerializedTx
        {
            get { return __pbn__SerializedTx; }
            set { __pbn__SerializedTx = value; }
        }
        public bool ShouldSerializeSerializedTx() => __pbn__SerializedTx != null;
        public void ResetSerializedTx() => __pbn__SerializedTx = null;
        private byte[] __pbn__SerializedTx;

    }
}