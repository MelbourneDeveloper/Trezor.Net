namespace Trezor.Net.Contracts.Tezos
{
    [ProtoBuf.ProtoContract()]
    public class TezosSignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"branch")]
        public byte[] Branch { get; set; }
        public bool ShouldSerializeBranch() => Branch != null;
        public void ResetBranch() => Branch = null;

        [ProtoBuf.ProtoMember(3, Name = @"reveal")]
        public TezosRevealOp Reveal { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"transaction")]
        public TezosTransactionOp Transaction { get; set; }

        [ProtoBuf.ProtoMember(5, Name = @"origination")]
        public TezosOriginationOp Origination { get; set; }

        [ProtoBuf.ProtoMember(6, Name = @"delegation")]
        public TezosDelegationOp Delegation { get; set; }

        [ProtoBuf.ProtoContract()]
        public class TezosContractID : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"tag")]
            [System.ComponentModel.DefaultValue(TezosContractType.Implicit)]
            public TezosContractType Tag
            {
                get { return __pbn__Tag ?? TezosContractType.Implicit; }
                set { __pbn__Tag = value; }
            }
            public bool ShouldSerializeTag() => __pbn__Tag != null;
            public void ResetTag() => __pbn__Tag = null;
            private TezosContractType? __pbn__Tag;

            [ProtoBuf.ProtoMember(2, Name = @"hash")]
            public byte[] Hash { get; set; }
            public bool ShouldSerializeHash() => Hash != null;
            public void ResetHash() => Hash = null;

            [ProtoBuf.ProtoContract()]
            public enum TezosContractType
            {
                Implicit = 0,
                Originated = 1,
            }

        }

        [ProtoBuf.ProtoContract()]
        public class TezosRevealOp : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosContractID Source { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [ProtoBuf.ProtoMember(6, Name = @"public_key")]
            public byte[] PublicKey { get; set; }
            public bool ShouldSerializePublicKey() => PublicKey != null;
            public void ResetPublicKey() => PublicKey = null;
        }

        [ProtoBuf.ProtoContract()]
        public class TezosTransactionOp : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosContractID Source { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [ProtoBuf.ProtoMember(6, Name = @"amount")]
            public ulong Amount
            {
                get { return __pbn__Amount.GetValueOrDefault(); }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

            [ProtoBuf.ProtoMember(7, Name = @"destination")]
            public TezosContractID Destination { get; set; }

            [ProtoBuf.ProtoMember(8, Name = @"parameters")]
            public byte[] Parameters { get; set; }
            public bool ShouldSerializeParameters() => Parameters != null;
            public void ResetParameters() => Parameters = null;
        }

        [ProtoBuf.ProtoContract()]
        public class TezosOriginationOp : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosContractID Source { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [ProtoBuf.ProtoMember(6, Name = @"manager_pubkey")]
            public byte[] ManagerPubkey { get; set; }
            public bool ShouldSerializeManagerPubkey() => ManagerPubkey != null;
            public void ResetManagerPubkey() => ManagerPubkey = null;

            [ProtoBuf.ProtoMember(7, Name = @"balance")]
            public ulong Balance
            {
                get { return __pbn__Balance.GetValueOrDefault(); }
                set { __pbn__Balance = value; }
            }
            public bool ShouldSerializeBalance() => __pbn__Balance != null;
            public void ResetBalance() => __pbn__Balance = null;
            private ulong? __pbn__Balance;

            [ProtoBuf.ProtoMember(8, Name = @"spendable")]
            public bool Spendable
            {
                get { return __pbn__Spendable.GetValueOrDefault(); }
                set { __pbn__Spendable = value; }
            }
            public bool ShouldSerializeSpendable() => __pbn__Spendable != null;
            public void ResetSpendable() => __pbn__Spendable = null;
            private bool? __pbn__Spendable;

            [ProtoBuf.ProtoMember(9, Name = @"delegatable")]
            public bool Delegatable
            {
                get { return __pbn__Delegatable.GetValueOrDefault(); }
                set { __pbn__Delegatable = value; }
            }
            public bool ShouldSerializeDelegatable() => __pbn__Delegatable != null;
            public void ResetDelegatable() => __pbn__Delegatable = null;
            private bool? __pbn__Delegatable;

            [ProtoBuf.ProtoMember(10, Name = @"delegate")]
            public byte[] Delegate { get; set; }
            public bool ShouldSerializeDelegate() => Delegate != null;
            public void ResetDelegate() => Delegate = null;

            [ProtoBuf.ProtoMember(11, Name = @"script")]
            public byte[] Script { get; set; }
            public bool ShouldSerializeScript() => Script != null;
            public void ResetScript() => Script = null;
        }

        [ProtoBuf.ProtoContract()]
        public class TezosDelegationOp : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"source")]
            public TezosContractID Source { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(3, Name = @"counter")]
            public ulong Counter
            {
                get { return __pbn__Counter.GetValueOrDefault(); }
                set { __pbn__Counter = value; }
            }
            public bool ShouldSerializeCounter() => __pbn__Counter != null;
            public void ResetCounter() => __pbn__Counter = null;
            private ulong? __pbn__Counter;

            [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
            public ulong GasLimit
            {
                get { return __pbn__GasLimit.GetValueOrDefault(); }
                set { __pbn__GasLimit = value; }
            }
            public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
            public void ResetGasLimit() => __pbn__GasLimit = null;
            private ulong? __pbn__GasLimit;

            [ProtoBuf.ProtoMember(5, Name = @"storage_limit")]
            public ulong StorageLimit
            {
                get { return __pbn__StorageLimit.GetValueOrDefault(); }
                set { __pbn__StorageLimit = value; }
            }
            public bool ShouldSerializeStorageLimit() => __pbn__StorageLimit != null;
            public void ResetStorageLimit() => __pbn__StorageLimit = null;
            private ulong? __pbn__StorageLimit;

            [ProtoBuf.ProtoMember(6, Name = @"delegate")]
            public byte[] Delegate { get; set; }
            public bool ShouldSerializeDelegate() => Delegate != null;
            public void ResetDelegate() => Delegate = null;
        }

    }
}