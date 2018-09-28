namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologySignOntIdRegister : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
        public OntologyTransaction Transaction { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_register")]
        public OntologyOntIdRegister OntIdRegister { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class OntologyOntIdRegister : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [global::ProtoBuf.ProtoMember(1, Name = @"ont_id")]
            [global::System.ComponentModel.DefaultValue("")]
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

            [global::ProtoBuf.ProtoMember(2, Name = @"public_key")]
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