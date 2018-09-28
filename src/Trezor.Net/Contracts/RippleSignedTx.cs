namespace Trezor.Net.Contracts.Ripple
{
    [global::ProtoBuf.ProtoContract()]
    public class RippleSignedTx : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"serialized_tx")]
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