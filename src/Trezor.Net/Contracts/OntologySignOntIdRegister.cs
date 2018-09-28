namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignOntIdRegister : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"transaction")]
        public OntologyTransaction Transaction { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"ont_id_register")]
        public OntologyOntIdRegister OntIdRegister { get; set; }

        [ProtoBuf.ProtoContract()]
        public class OntologyOntIdRegister : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [ProtoBuf.ProtoMember(1, Name = @"ont_id")]
            [System.ComponentModel.DefaultValue("")]
            public string OntId
            {
                get => __pbn__OntId ?? "";
                set => __pbn__OntId = value;
            }
            public bool ShouldSerializeOntId()
            {
                return __pbn__OntId != null;
            }

            public void ResetOntId()
            {
                __pbn__OntId = null;
            }

            private string __pbn__OntId;

            [ProtoBuf.ProtoMember(2, Name = @"public_key")]
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
}