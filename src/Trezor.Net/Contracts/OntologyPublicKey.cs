namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologyPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public byte[] PublicKey
        {
            get => __pbn__PublicKey;
            set => __pbn__PublicKey = value;
        }
        public bool ShouldSerializePublicKey()
        {
            return __pbn__PublicKey != null;
        }

        public void ResetPublicKey()
        {
            __pbn__PublicKey = null;
        }

        private byte[] __pbn__PublicKey;

    }
}