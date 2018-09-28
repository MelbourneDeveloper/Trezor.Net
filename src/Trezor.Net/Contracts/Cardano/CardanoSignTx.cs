namespace Trezor.Net.Contracts.Cardano
{
    [ProtoBuf.ProtoContract()]
    public class CardanoSignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"inputs")]
        public System.Collections.Generic.List<CardanoTxInputType> Inputs { get; } = new System.Collections.Generic.List<CardanoTxInputType>();

        [ProtoBuf.ProtoMember(2, Name = @"outputs")]
        public System.Collections.Generic.List<CardanoTxOutputType> Outputs { get; } = new System.Collections.Generic.List<CardanoTxOutputType>();

        [ProtoBuf.ProtoMember(3, Name = @"transactions_count")]
        public uint TransactionsCount
        {
            get { return __pbn__TransactionsCount.GetValueOrDefault(); }
            set { __pbn__TransactionsCount = value; }
        }
        public bool ShouldSerializeTransactionsCount() => __pbn__TransactionsCount != null;
        public void ResetTransactionsCount() => __pbn__TransactionsCount = null;
        private uint? __pbn__TransactionsCount;

        [ProtoBuf.ProtoContract()]
        public class CardanoTxInputType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"prev_hash")]
            public byte[] PrevHash { get; set; }
            public bool ShouldSerializePrevHash() => PrevHash != null;
            public void ResetPrevHash() => PrevHash = null;

            [ProtoBuf.ProtoMember(3, Name = @"prev_index")]
            public uint PrevIndex
            {
                get { return __pbn__PrevIndex.GetValueOrDefault(); }
                set { __pbn__PrevIndex = value; }
            }
            public bool ShouldSerializePrevIndex() => __pbn__PrevIndex != null;
            public void ResetPrevIndex() => __pbn__PrevIndex = null;
            private uint? __pbn__PrevIndex;

            [ProtoBuf.ProtoMember(4, Name = @"type")]
            public uint Type
            {
                get { return __pbn__Type.GetValueOrDefault(); }
                set { __pbn__Type = value; }
            }
            public bool ShouldSerializeType() => __pbn__Type != null;
            public void ResetType() => __pbn__Type = null;
            private uint? __pbn__Type;

        }

        [ProtoBuf.ProtoContract()]
        public class CardanoTxOutputType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"address")]
            [System.ComponentModel.DefaultValue("")]
            public string Address
            {
                get { return __pbn__Address ?? ""; }
                set { __pbn__Address = value; }
            }
            public bool ShouldSerializeAddress() => __pbn__Address != null;
            public void ResetAddress() => __pbn__Address = null;
            private string __pbn__Address;

            [ProtoBuf.ProtoMember(2, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

            [ProtoBuf.ProtoMember(3, Name = @"amount")]
            public ulong Amount
            {
                get { return __pbn__Amount.GetValueOrDefault(); }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

        }

    }
}