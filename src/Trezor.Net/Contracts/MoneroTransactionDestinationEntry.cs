namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionDestinationEntry : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"amount")]
        public ulong Amount
        {
            get { return __pbn__Amount.GetValueOrDefault(); }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

        [global::ProtoBuf.ProtoMember(2, Name = @"addr")]
        public MoneroAccountPublicAddress Addr { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"is_subaddress")]
        public bool IsSubaddress
        {
            get { return __pbn__IsSubaddress.GetValueOrDefault(); }
            set { __pbn__IsSubaddress = value; }
        }
        public bool ShouldSerializeIsSubaddress() => __pbn__IsSubaddress != null;
        public void ResetIsSubaddress() => __pbn__IsSubaddress = null;
        private bool? __pbn__IsSubaddress;

        [global::ProtoBuf.ProtoContract()]
        public class MoneroAccountPublicAddress : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"spend_public_key")]
            public byte[] SpendPublicKey
            {
                get { return __pbn__SpendPublicKey; }
                set { __pbn__SpendPublicKey = value; }
            }
            public bool ShouldSerializeSpendPublicKey() => __pbn__SpendPublicKey != null;
            public void ResetSpendPublicKey() => __pbn__SpendPublicKey = null;
            private byte[] __pbn__SpendPublicKey;

            [global::ProtoBuf.ProtoMember(2, Name = @"view_public_key")]
            public byte[] ViewPublicKey
            {
                get { return __pbn__ViewPublicKey; }
                set { __pbn__ViewPublicKey = value; }
            }
            public bool ShouldSerializeViewPublicKey() => __pbn__ViewPublicKey != null;
            public void ResetViewPublicKey() => __pbn__ViewPublicKey = null;
            private byte[] __pbn__ViewPublicKey;

        }

    }
}