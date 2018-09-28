namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologySignOntIdAddAttributes : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_add_attributes")]
        public OntologyOntIdAddAttributes OntIdAddAttributes { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class OntologyOntIdAddAttributes : global::ProtoBuf.IExtensible
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

            [global::ProtoBuf.ProtoMember(3, Name = @"ont_id_attributes")]
            public global::System.Collections.Generic.List<OntologyOntIdAttribute> OntIdAttributes { get; } = new global::System.Collections.Generic.List<OntologyOntIdAttribute>();

            [global::ProtoBuf.ProtoContract()]
            public class OntologyOntIdAttribute : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                {
                    return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
                }

                [global::ProtoBuf.ProtoMember(1, Name = @"key")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Key
                {
                    get => __pbn__Key ?? "";
                    set => __pbn__Key = value;
                }
                public bool ShouldSerializeKey()
                {
                    return __pbn__Key != null;
                }

                public void ResetKey()
                {
                    __pbn__Key = null;
                }

                private string __pbn__Key;

                [global::ProtoBuf.ProtoMember(2, Name = @"type")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Type
                {
                    get => __pbn__Type ?? "";
                    set => __pbn__Type = value;
                }
                public bool ShouldSerializeType()
                {
                    return __pbn__Type != null;
                }

                public void ResetType()
                {
                    __pbn__Type = null;
                }

                private string __pbn__Type;

                [global::ProtoBuf.ProtoMember(3, Name = @"value")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Value
                {
                    get => __pbn__Value ?? "";
                    set => __pbn__Value = value;
                }
                public bool ShouldSerializeValue()
                {
                    return __pbn__Value != null;
                }

                public void ResetValue()
                {
                    __pbn__Value = null;
                }

                private string __pbn__Value;

            }

        }

    }
}