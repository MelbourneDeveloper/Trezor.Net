namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionInitRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"version")]
        public uint Version
        {
            get { return __pbn__Version.GetValueOrDefault(); }
            set { __pbn__Version = value; }
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"network_type")]
        public uint NetworkType
        {
            get { return __pbn__NetworkType.GetValueOrDefault(); }
            set { __pbn__NetworkType = value; }
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [global::ProtoBuf.ProtoMember(4, Name = @"tsx_data")]
        public MoneroTransactionData TsxData { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class MoneroTransactionData : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"version")]
            public uint Version
            {
                get { return __pbn__Version.GetValueOrDefault(); }
                set { __pbn__Version = value; }
            }
            public bool ShouldSerializeVersion() => __pbn__Version != null;
            public void ResetVersion() => __pbn__Version = null;
            private uint? __pbn__Version;

            [global::ProtoBuf.ProtoMember(2, Name = @"payment_id")]
            public byte[] PaymentId
            {
                get { return __pbn__PaymentId; }
                set { __pbn__PaymentId = value; }
            }
            public bool ShouldSerializePaymentId() => __pbn__PaymentId != null;
            public void ResetPaymentId() => __pbn__PaymentId = null;
            private byte[] __pbn__PaymentId;

            [global::ProtoBuf.ProtoMember(3, Name = @"unlock_time")]
            public ulong UnlockTime
            {
                get { return __pbn__UnlockTime.GetValueOrDefault(); }
                set { __pbn__UnlockTime = value; }
            }
            public bool ShouldSerializeUnlockTime() => __pbn__UnlockTime != null;
            public void ResetUnlockTime() => __pbn__UnlockTime = null;
            private ulong? __pbn__UnlockTime;

            [global::ProtoBuf.ProtoMember(4, Name = @"outputs")]
            public global::System.Collections.Generic.List<MoneroTransactionDestinationEntry> Outputs { get; } = new global::System.Collections.Generic.List<MoneroTransactionDestinationEntry>();

            [global::ProtoBuf.ProtoMember(5, Name = @"change_dts")]
            public MoneroTransactionDestinationEntry ChangeDts { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"num_inputs")]
            public uint NumInputs
            {
                get { return __pbn__NumInputs.GetValueOrDefault(); }
                set { __pbn__NumInputs = value; }
            }
            public bool ShouldSerializeNumInputs() => __pbn__NumInputs != null;
            public void ResetNumInputs() => __pbn__NumInputs = null;
            private uint? __pbn__NumInputs;

            [global::ProtoBuf.ProtoMember(7, Name = @"mixin")]
            public uint Mixin
            {
                get { return __pbn__Mixin.GetValueOrDefault(); }
                set { __pbn__Mixin = value; }
            }
            public bool ShouldSerializeMixin() => __pbn__Mixin != null;
            public void ResetMixin() => __pbn__Mixin = null;
            private uint? __pbn__Mixin;

            [global::ProtoBuf.ProtoMember(8, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(9, Name = @"account")]
            public uint Account
            {
                get { return __pbn__Account.GetValueOrDefault(); }
                set { __pbn__Account = value; }
            }
            public bool ShouldSerializeAccount() => __pbn__Account != null;
            public void ResetAccount() => __pbn__Account = null;
            private uint? __pbn__Account;

            [global::ProtoBuf.ProtoMember(10, Name = @"minor_indices")]
            public uint[] MinorIndices { get; set; }

            [global::ProtoBuf.ProtoMember(11, Name = @"is_multisig")]
            public bool IsMultisig
            {
                get { return __pbn__IsMultisig.GetValueOrDefault(); }
                set { __pbn__IsMultisig = value; }
            }
            public bool ShouldSerializeIsMultisig() => __pbn__IsMultisig != null;
            public void ResetIsMultisig() => __pbn__IsMultisig = null;
            private bool? __pbn__IsMultisig;

            [global::ProtoBuf.ProtoMember(12, Name = @"exp_tx_prefix_hash")]
            public byte[] ExpTxPrefixHash
            {
                get { return __pbn__ExpTxPrefixHash; }
                set { __pbn__ExpTxPrefixHash = value; }
            }
            public bool ShouldSerializeExpTxPrefixHash() => __pbn__ExpTxPrefixHash != null;
            public void ResetExpTxPrefixHash() => __pbn__ExpTxPrefixHash = null;
            private byte[] __pbn__ExpTxPrefixHash;

            [global::ProtoBuf.ProtoMember(13, Name = @"use_tx_keys")]
            public global::System.Collections.Generic.List<byte[]> UseTxKeys { get; } = new global::System.Collections.Generic.List<byte[]>();

            [global::ProtoBuf.ProtoMember(14, Name = @"rsig_data")]
            public MoneroTransactionRsigData RsigData { get; set; }

            [global::ProtoBuf.ProtoMember(15, Name = @"integrated_indices")]
            public uint[] IntegratedIndices { get; set; }

        }

    }
}