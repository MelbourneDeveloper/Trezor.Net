namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionAllOutSetAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"extra")]
        public byte[] Extra { get; set; }
        public bool ShouldSerializeExtra() => Extra != null;
        public void ResetExtra() => Extra = null;

        [ProtoBuf.ProtoMember(2, Name = @"tx_prefix_hash")]
        public byte[] TxPrefixHash { get; set; }
        public bool ShouldSerializeTxPrefixHash() => TxPrefixHash != null;
        public void ResetTxPrefixHash() => TxPrefixHash = null;

        [ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"rv")]
        public MoneroRingCtSig Rv { get; set; }

        [ProtoBuf.ProtoContract()]
        public class MoneroRingCtSig : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"txn_fee")]
            public ulong TxnFee
            {
                get => __pbn__TxnFee.GetValueOrDefault();
                set => __pbn__TxnFee = value;
            }
            public bool ShouldSerializeTxnFee() => __pbn__TxnFee != null;
            public void ResetTxnFee() => __pbn__TxnFee = null;
            private ulong? __pbn__TxnFee;

            [ProtoBuf.ProtoMember(2, Name = @"message")]
            public byte[] Message { get; set; }
            public bool ShouldSerializeMessage() => Message != null;
            public void ResetMessage() => Message = null;

            [ProtoBuf.ProtoMember(3, Name = @"rv_type")]
            public uint RvType
            {
                get => __pbn__RvType.GetValueOrDefault();
                set => __pbn__RvType = value;
            }
            public bool ShouldSerializeRvType() => __pbn__RvType != null;
            public void ResetRvType() => __pbn__RvType = null;
            private uint? __pbn__RvType;

        }

    }
}