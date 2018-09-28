namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionInitRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"version")]
        public uint Version
        {
            get => __pbn__Version.GetValueOrDefault();
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoBuf.ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"network_type")]
        public uint NetworkType
        {
            get => __pbn__NetworkType.GetValueOrDefault();
            set => __pbn__NetworkType = value;
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [ProtoBuf.ProtoMember(4, Name = @"tsx_data")]
        public MoneroTransactionData TsxData { get; set; }

        [ProtoBuf.ProtoContract()]
        public class MoneroTransactionData : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"version")]
            public uint Version
            {
                get => __pbn__Version.GetValueOrDefault();
                set => __pbn__Version = value;
            }
            public bool ShouldSerializeVersion() => __pbn__Version != null;
            public void ResetVersion() => __pbn__Version = null;
            private uint? __pbn__Version;

            [ProtoBuf.ProtoMember(2, Name = @"payment_id")]
            public byte[] PaymentId { get; set; }
            public bool ShouldSerializePaymentId() => PaymentId != null;
            public void ResetPaymentId() => PaymentId = null;

            [ProtoBuf.ProtoMember(3, Name = @"unlock_time")]
            public ulong UnlockTime
            {
                get => __pbn__UnlockTime.GetValueOrDefault();
                set => __pbn__UnlockTime = value;
            }
            public bool ShouldSerializeUnlockTime() => __pbn__UnlockTime != null;
            public void ResetUnlockTime() => __pbn__UnlockTime = null;
            private ulong? __pbn__UnlockTime;

            [ProtoBuf.ProtoMember(4, Name = @"outputs")]
            public System.Collections.Generic.List<MoneroTransactionDestinationEntry> Outputs { get; } = new System.Collections.Generic.List<MoneroTransactionDestinationEntry>();

            [ProtoBuf.ProtoMember(5, Name = @"change_dts")]
            public MoneroTransactionDestinationEntry ChangeDts { get; set; }

            [ProtoBuf.ProtoMember(6, Name = @"num_inputs")]
            public uint NumInputs
            {
                get => __pbn__NumInputs.GetValueOrDefault();
                set => __pbn__NumInputs = value;
            }
            public bool ShouldSerializeNumInputs() => __pbn__NumInputs != null;
            public void ResetNumInputs() => __pbn__NumInputs = null;
            private uint? __pbn__NumInputs;

            [ProtoBuf.ProtoMember(7, Name = @"mixin")]
            public uint Mixin
            {
                get => __pbn__Mixin.GetValueOrDefault();
                set => __pbn__Mixin = value;
            }
            public bool ShouldSerializeMixin() => __pbn__Mixin != null;
            public void ResetMixin() => __pbn__Mixin = null;
            private uint? __pbn__Mixin;

            [ProtoBuf.ProtoMember(8, Name = @"fee")]
            public ulong Fee
            {
                get => __pbn__Fee.GetValueOrDefault();
                set => __pbn__Fee = value;
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(9, Name = @"account")]
            public uint Account
            {
                get => __pbn__Account.GetValueOrDefault();
                set => __pbn__Account = value;
            }
            public bool ShouldSerializeAccount() => __pbn__Account != null;
            public void ResetAccount() => __pbn__Account = null;
            private uint? __pbn__Account;

            [ProtoBuf.ProtoMember(10, Name = @"minor_indices")]
            public uint[] MinorIndices { get; set; }

            [ProtoBuf.ProtoMember(11, Name = @"is_multisig")]
            public bool IsMultisig
            {
                get => __pbn__IsMultisig.GetValueOrDefault();
                set => __pbn__IsMultisig = value;
            }
            public bool ShouldSerializeIsMultisig() => __pbn__IsMultisig != null;
            public void ResetIsMultisig() => __pbn__IsMultisig = null;
            private bool? __pbn__IsMultisig;

            [ProtoBuf.ProtoMember(12, Name = @"exp_tx_prefix_hash")]
            public byte[] ExpTxPrefixHash { get; set; }
            public bool ShouldSerializeExpTxPrefixHash() => ExpTxPrefixHash != null;
            public void ResetExpTxPrefixHash() => ExpTxPrefixHash = null;

            [ProtoBuf.ProtoMember(13, Name = @"use_tx_keys")]
            public System.Collections.Generic.List<byte[]> UseTxKeys { get; } = new System.Collections.Generic.List<byte[]>();

            [ProtoBuf.ProtoMember(14, Name = @"rsig_data")]
            public MoneroTransactionRsigData RsigData { get; set; }

            [ProtoBuf.ProtoMember(15, Name = @"integrated_indices")]
            public uint[] IntegratedIndices { get; set; }

        }

    }
}