namespace Trezor.Net.Contracts.Ripple
{
    [global::ProtoBuf.ProtoContract()]
    public class RippleSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"fee")]
        public ulong Fee
        {
            get { return __pbn__Fee.GetValueOrDefault(); }
            set { __pbn__Fee = value; }
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

        [global::ProtoBuf.ProtoMember(3, Name = @"flags")]
        public uint Flags
        {
            get { return __pbn__Flags.GetValueOrDefault(); }
            set { __pbn__Flags = value; }
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

        [global::ProtoBuf.ProtoMember(4, Name = @"sequence")]
        public uint Sequence
        {
            get { return __pbn__Sequence.GetValueOrDefault(); }
            set { __pbn__Sequence = value; }
        }
        public bool ShouldSerializeSequence() => __pbn__Sequence != null;
        public void ResetSequence() => __pbn__Sequence = null;
        private uint? __pbn__Sequence;

        [global::ProtoBuf.ProtoMember(5, Name = @"last_ledger_sequence")]
        public uint LastLedgerSequence
        {
            get { return __pbn__LastLedgerSequence.GetValueOrDefault(); }
            set { __pbn__LastLedgerSequence = value; }
        }
        public bool ShouldSerializeLastLedgerSequence() => __pbn__LastLedgerSequence != null;
        public void ResetLastLedgerSequence() => __pbn__LastLedgerSequence = null;
        private uint? __pbn__LastLedgerSequence;

        [global::ProtoBuf.ProtoMember(6, Name = @"payment")]
        public RipplePayment Payment { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class RipplePayment : global::ProtoBuf.IExtensible
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

            [global::ProtoBuf.ProtoMember(2, Name = @"destination")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Destination
            {
                get { return __pbn__Destination ?? ""; }
                set { __pbn__Destination = value; }
            }
            public bool ShouldSerializeDestination() => __pbn__Destination != null;
            public void ResetDestination() => __pbn__Destination = null;
            private string __pbn__Destination;

        }

    }
}