namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignOntIdAddAttributes : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(3, Name = @"ont_id_add_attributes")]
        public OntologyOntIdAddAttributes OntIdAddAttributes { get; set; }

        [ProtoBuf.ProtoContract()]
        public class OntologyOntIdAddAttributes : ProtoBuf.IExtensible
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
            public byte[] PublicKey { get; set; }
            public bool ShouldSerializePublicKey()
            {
                return PublicKey != null;
            }

            public void ResetPublicKey()
            {
                PublicKey = null;
            }

            [ProtoBuf.ProtoMember(3, Name = @"ont_id_attributes")]
            public System.Collections.Generic.List<OntologyOntIdAttribute> OntIdAttributes { get; } = new System.Collections.Generic.List<OntologyOntIdAttribute>();

            [ProtoBuf.ProtoContract()]
            public class OntologyOntIdAttribute : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                {
                    return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
                }

                [ProtoBuf.ProtoMember(1, Name = @"key")]
                [System.ComponentModel.DefaultValue("")]
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

                [ProtoBuf.ProtoMember(2, Name = @"type")]
                [System.ComponentModel.DefaultValue("")]
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

                [ProtoBuf.ProtoMember(3, Name = @"value")]
                [System.ComponentModel.DefaultValue("")]
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