namespace Trezor.Net.Contracts.Lisk
{
    [global::ProtoBuf.ProtoContract()]
    public class LiskPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

    }
}