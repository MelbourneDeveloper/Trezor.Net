namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionDestinationEntry : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"amount")]
        public ulong Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

        [ProtoBuf.ProtoMember(2, Name = @"addr")]
        public MoneroAccountPublicAddress Addr { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"is_subaddress")]
        public bool IsSubaddress
        {
            get => __pbn__IsSubaddress.GetValueOrDefault();
            set => __pbn__IsSubaddress = value;
        }
        public bool ShouldSerializeIsSubaddress() => __pbn__IsSubaddress != null;
        public void ResetIsSubaddress() => __pbn__IsSubaddress = null;
        private bool? __pbn__IsSubaddress;

        [ProtoBuf.ProtoContract()]
        public class MoneroAccountPublicAddress : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"spend_public_key")]
            public byte[] SpendPublicKey { get; set; }
            public bool ShouldSerializeSpendPublicKey() => SpendPublicKey != null;
            public void ResetSpendPublicKey() => SpendPublicKey = null;

            [ProtoBuf.ProtoMember(2, Name = @"view_public_key")]
            public byte[] ViewPublicKey { get; set; }
            public bool ShouldSerializeViewPublicKey() => ViewPublicKey != null;
            public void ResetViewPublicKey() => ViewPublicKey = null;
        }

    }
}