namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologySignedWithdrawOng : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature
        {
            get => __pbn__Signature;
            set => __pbn__Signature = value;
        }
        public bool ShouldSerializeSignature()
        {
            return __pbn__Signature != null;
        }

        public void ResetSignature()
        {
            __pbn__Signature = null;
        }

        private byte[] __pbn__Signature;

        [global::ProtoBuf.ProtoMember(2, Name = @"payload")]
        public byte[] Payload
        {
            get => __pbn__Payload;
            set => __pbn__Payload = value;
        }
        public bool ShouldSerializePayload()
        {
            return __pbn__Payload != null;
        }

        public void ResetPayload()
        {
            __pbn__Payload = null;
        }

        private byte[] __pbn__Payload;

    }
}