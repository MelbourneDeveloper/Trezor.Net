namespace Trezor.Net.Contracts.Ripple
{
    [ProtoBuf.ProtoContract()]
    public class RippleSignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"fee")]
        public ulong Fee
        {
            get { return __pbn__Fee.GetValueOrDefault(); }
            set { __pbn__Fee = value; }
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

        [ProtoBuf.ProtoMember(3, Name = @"flags")]
        public uint Flags
        {
            get { return __pbn__Flags.GetValueOrDefault(); }
            set { __pbn__Flags = value; }
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

        [ProtoBuf.ProtoMember(4, Name = @"sequence")]
        public uint Sequence
        {
            get { return __pbn__Sequence.GetValueOrDefault(); }
            set { __pbn__Sequence = value; }
        }
        public bool ShouldSerializeSequence() => __pbn__Sequence != null;
        public void ResetSequence() => __pbn__Sequence = null;
        private uint? __pbn__Sequence;

        [ProtoBuf.ProtoMember(5, Name = @"last_ledger_sequence")]
        public uint LastLedgerSequence
        {
            get { return __pbn__LastLedgerSequence.GetValueOrDefault(); }
            set { __pbn__LastLedgerSequence = value; }
        }
        public bool ShouldSerializeLastLedgerSequence() => __pbn__LastLedgerSequence != null;
        public void ResetLastLedgerSequence() => __pbn__LastLedgerSequence = null;
        private uint? __pbn__LastLedgerSequence;

        [ProtoBuf.ProtoMember(6, Name = @"payment")]
        public RipplePayment Payment { get; set; }

        [ProtoBuf.ProtoContract()]
        public class RipplePayment : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"amount")]
            public ulong Amount
            {
                get { return __pbn__Amount.GetValueOrDefault(); }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

            [ProtoBuf.ProtoMember(2, Name = @"destination")]
            [System.ComponentModel.DefaultValue("")]
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