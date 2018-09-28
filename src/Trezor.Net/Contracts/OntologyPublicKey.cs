namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologyPublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"public_key")]
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