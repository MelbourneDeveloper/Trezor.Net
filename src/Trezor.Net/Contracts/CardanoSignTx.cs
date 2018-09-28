namespace Trezor.Net.Contracts.Cardano
{
    [global::ProtoBuf.ProtoContract()]
    public class CardanoSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"inputs")]
        public global::System.Collections.Generic.List<CardanoTxInputType> Inputs { get; } = new global::System.Collections.Generic.List<CardanoTxInputType>();

        [global::ProtoBuf.ProtoMember(2, Name = @"outputs")]
        public global::System.Collections.Generic.List<CardanoTxOutputType> Outputs { get; } = new global::System.Collections.Generic.List<CardanoTxOutputType>();

        [global::ProtoBuf.ProtoMember(3, Name = @"transactions_count")]
        public uint TransactionsCount
        {
            get { return __pbn__TransactionsCount.GetValueOrDefault(); }
            set { __pbn__TransactionsCount = value; }
        }
        public bool ShouldSerializeTransactionsCount() => __pbn__TransactionsCount != null;
        public void ResetTransactionsCount() => __pbn__TransactionsCount = null;
        private uint? __pbn__TransactionsCount;

        [global::ProtoBuf.ProtoContract()]
        public class CardanoTxInputType : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"prev_hash")]
            public byte[] PrevHash
            {
                get { return __pbn__PrevHash; }
                set { __pbn__PrevHash = value; }
            }
            public bool ShouldSerializePrevHash() => __pbn__PrevHash != null;
            public void ResetPrevHash() => __pbn__PrevHash = null;
            private byte[] __pbn__PrevHash;

            [global::ProtoBuf.ProtoMember(3, Name = @"prev_index")]
            public uint PrevIndex
            {
                get { return __pbn__PrevIndex.GetValueOrDefault(); }
                set { __pbn__PrevIndex = value; }
            }
            public bool ShouldSerializePrevIndex() => __pbn__PrevIndex != null;
            public void ResetPrevIndex() => __pbn__PrevIndex = null;
            private uint? __pbn__PrevIndex;

            [global::ProtoBuf.ProtoMember(4, Name = @"type")]
            public uint Type
            {
                get { return __pbn__Type.GetValueOrDefault(); }
                set { __pbn__Type = value; }
            }
            public bool ShouldSerializeType() => __pbn__Type != null;
            public void ResetType() => __pbn__Type = null;
            private uint? __pbn__Type;

        }

        [global::ProtoBuf.ProtoContract()]
        public class CardanoTxOutputType : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"address")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Address
            {
                get { return __pbn__Address ?? ""; }
                set { __pbn__Address = value; }
            }
            public bool ShouldSerializeAddress() => __pbn__Address != null;
            public void ResetAddress() => __pbn__Address = null;
            private string __pbn__Address;

            [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"amount")]
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