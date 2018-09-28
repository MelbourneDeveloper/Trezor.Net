namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionAllOutSetAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"extra")]
        public byte[] Extra
        {
            get { return __pbn__Extra; }
            set { __pbn__Extra = value; }
        }
        public bool ShouldSerializeExtra() => __pbn__Extra != null;
        public void ResetExtra() => __pbn__Extra = null;
        private byte[] __pbn__Extra;

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_prefix_hash")]
        public byte[] TxPrefixHash
        {
            get { return __pbn__TxPrefixHash; }
            set { __pbn__TxPrefixHash = value; }
        }
        public bool ShouldSerializeTxPrefixHash() => __pbn__TxPrefixHash != null;
        public void ResetTxPrefixHash() => __pbn__TxPrefixHash = null;
        private byte[] __pbn__TxPrefixHash;

        [global::ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"rv")]
        public MoneroRingCtSig Rv { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class MoneroRingCtSig : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"txn_fee")]
            public ulong TxnFee
            {
                get { return __pbn__TxnFee.GetValueOrDefault(); }
                set { __pbn__TxnFee = value; }
            }
            public bool ShouldSerializeTxnFee() => __pbn__TxnFee != null;
            public void ResetTxnFee() => __pbn__TxnFee = null;
            private ulong? __pbn__TxnFee;

            [global::ProtoBuf.ProtoMember(2, Name = @"message")]
            public byte[] Message
            {
                get { return __pbn__Message; }
                set { __pbn__Message = value; }
            }
            public bool ShouldSerializeMessage() => __pbn__Message != null;
            public void ResetMessage() => __pbn__Message = null;
            private byte[] __pbn__Message;

            [global::ProtoBuf.ProtoMember(3, Name = @"rv_type")]
            public uint RvType
            {
                get { return __pbn__RvType.GetValueOrDefault(); }
                set { __pbn__RvType = value; }
            }
            public bool ShouldSerializeRvType() => __pbn__RvType != null;
            public void ResetRvType() => __pbn__RvType = null;
            private uint? __pbn__RvType;

        }

    }
}