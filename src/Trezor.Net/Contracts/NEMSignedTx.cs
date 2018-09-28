namespace Trezor.Net.Contracts.NEM
{
    [global::ProtoBuf.ProtoContract()]
    public class NEMSignedTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data")]
        public byte[] Data
        {
            get { return __pbn__Data; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private byte[] __pbn__Data;

        [global::ProtoBuf.ProtoMember(2, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

    }
}