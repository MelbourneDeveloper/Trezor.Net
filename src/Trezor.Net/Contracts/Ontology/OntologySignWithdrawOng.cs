namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologySignWithdrawOng : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(3, Name = @"withdraw_ong")]
        public OntologyWithdrawOng WithdrawOng { get; set; }

        [ProtoBuf.ProtoContract()]
        public class OntologyWithdrawOng : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }

            [ProtoBuf.ProtoMember(1, Name = @"amount")]
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

            [ProtoBuf.ProtoMember(2, Name = @"from_address")]
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

            [ProtoBuf.ProtoMember(3, Name = @"to_address")]
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

        }

    }
}