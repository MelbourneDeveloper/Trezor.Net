namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignedWithdrawOng : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"signature")]
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

        [ProtoBuf.ProtoMember(2, Name = @"payload")]
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