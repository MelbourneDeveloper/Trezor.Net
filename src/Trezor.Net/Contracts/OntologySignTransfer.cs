namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologySignTransfer : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(3, Name = @"transfer")]
        public OntologyTransfer Transfer { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class OntologyTransfer : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [global::ProtoBuf.ProtoMember(1, Name = @"asset")]
            [global::System.ComponentModel.DefaultValue(OntologyAsset.Ont)]
            public OntologyAsset Asset
            {
                get => __pbn__Asset ?? OntologyAsset.Ont;
                set => __pbn__Asset = value;
            }
            public bool ShouldSerializeAsset()
            {
                return __pbn__Asset != null;
            }

            public void ResetAsset()
            {
                __pbn__Asset = null;
            }

            private OntologyAsset? __pbn__Asset;

            [global::ProtoBuf.ProtoMember(2, Name = @"amount")]
            public ulong Amount
            {
                get => __pbn__Amount.GetValueOrDefault();
                set => __pbn__Amount = value;
            }
            public bool ShouldSerializeAmount()
            {
                return __pbn__Amount != null;
            }

            public void ResetAmount()
            {
                __pbn__Amount = null;
            }

            private ulong? __pbn__Amount;

            [global::ProtoBuf.ProtoMember(3, Name = @"from_address")]
            [global::System.ComponentModel.DefaultValue("")]
            public string FromAddress
            {
                get => __pbn__FromAddress ?? "";
                set => __pbn__FromAddress = value;
            }
            public bool ShouldSerializeFromAddress()
            {
                return __pbn__FromAddress != null;
            }

            public void ResetFromAddress()
            {
                __pbn__FromAddress = null;
            }

            private string __pbn__FromAddress;

            [global::ProtoBuf.ProtoMember(4, Name = @"to_address")]
            [global::System.ComponentModel.DefaultValue("")]
            public string ToAddress
            {
                get => __pbn__ToAddress ?? "";
                set => __pbn__ToAddress = value;
            }
            public bool ShouldSerializeToAddress()
            {
                return __pbn__ToAddress != null;
            }

            public void ResetToAddress()
            {
                __pbn__ToAddress = null;
            }

            private string __pbn__ToAddress;

            [global::ProtoBuf.ProtoContract()]
            public enum OntologyAsset
            {
                [global::ProtoBuf.ProtoEnum(Name = @"ONT")]
                Ont = 1,
                [global::ProtoBuf.ProtoEnum(Name = @"ONG")]
                Ong = 2,
            }

        }

    }
}