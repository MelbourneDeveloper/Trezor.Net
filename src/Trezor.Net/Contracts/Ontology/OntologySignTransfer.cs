namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignTransfer : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(3, Name = @"transfer")]
        public OntologyTransfer Transfer { get; set; }

        [ProtoBuf.ProtoContract()]
        public class OntologyTransfer : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [ProtoBuf.ProtoMember(1, Name = @"asset")]
            [System.ComponentModel.DefaultValue(OntologyAsset.Ont)]
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

            [ProtoBuf.ProtoMember(2, Name = @"amount")]
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

            [ProtoBuf.ProtoMember(3, Name = @"from_address")]
            [System.ComponentModel.DefaultValue("")]
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

            [ProtoBuf.ProtoMember(4, Name = @"to_address")]
            [System.ComponentModel.DefaultValue("")]
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

            [ProtoBuf.ProtoContract()]
            public enum OntologyAsset
            {
                [ProtoBuf.ProtoEnum(Name = @"ONT")]
                Ont = 1,
                [ProtoBuf.ProtoEnum(Name = @"ONG")]
                Ong = 2,
            }

        }

    }
}