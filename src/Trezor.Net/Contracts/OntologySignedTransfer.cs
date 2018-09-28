namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignedTransfer : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature { get; set; }
        public bool ShouldSerializeSignature()
        {
            return Signature != null;
        }

        public void ResetSignature()
        {
            Signature = null;
        }

        [ProtoBuf.ProtoMember(2, Name = @"payload")]
        public byte[] Payload { get; set; }
        public bool ShouldSerializePayload()
        {
            return Payload != null;
        }

        public void ResetPayload()
        {
            Payload = null;
        }
    }
}