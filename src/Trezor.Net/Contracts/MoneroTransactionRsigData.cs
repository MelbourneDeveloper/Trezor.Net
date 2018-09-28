namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionRsigData : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"rsig_type")]
        public uint RsigType
        {
            get { return __pbn__RsigType.GetValueOrDefault(); }
            set { __pbn__RsigType = value; }
        }
        public bool ShouldSerializeRsigType() => __pbn__RsigType != null;
        public void ResetRsigType() => __pbn__RsigType = null;
        private uint? __pbn__RsigType;

        [global::ProtoBuf.ProtoMember(3, Name = @"offload_type")]
        public uint OffloadType
        {
            get { return __pbn__OffloadType.GetValueOrDefault(); }
            set { __pbn__OffloadType = value; }
        }
        public bool ShouldSerializeOffloadType() => __pbn__OffloadType != null;
        public void ResetOffloadType() => __pbn__OffloadType = null;
        private uint? __pbn__OffloadType;

        [global::ProtoBuf.ProtoMember(4, Name = @"grouping")]
        public ulong[] Groupings { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"step")]
        public uint Step
        {
            get { return __pbn__Step.GetValueOrDefault(); }
            set { __pbn__Step = value; }
        }
        public bool ShouldSerializeStep() => __pbn__Step != null;
        public void ResetStep() => __pbn__Step = null;
        private uint? __pbn__Step;

        [global::ProtoBuf.ProtoMember(6, Name = @"operation")]
        public ulong Operation
        {
            get { return __pbn__Operation.GetValueOrDefault(); }
            set { __pbn__Operation = value; }
        }
        public bool ShouldSerializeOperation() => __pbn__Operation != null;
        public void ResetOperation() => __pbn__Operation = null;
        private ulong? __pbn__Operation;

        [global::ProtoBuf.ProtoMember(7, Name = @"seed")]
        public byte[] Seed
        {
            get { return __pbn__Seed; }
            set { __pbn__Seed = value; }
        }
        public bool ShouldSerializeSeed() => __pbn__Seed != null;
        public void ResetSeed() => __pbn__Seed = null;
        private byte[] __pbn__Seed;

        [global::ProtoBuf.ProtoMember(8, Name = @"mask")]
        public byte[] Mask
        {
            get { return __pbn__Mask; }
            set { __pbn__Mask = value; }
        }
        public bool ShouldSerializeMask() => __pbn__Mask != null;
        public void ResetMask() => __pbn__Mask = null;
        private byte[] __pbn__Mask;

        [global::ProtoBuf.ProtoMember(9, Name = @"amount")]
        public byte[] Amount
        {
            get { return __pbn__Amount; }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private byte[] __pbn__Amount;

        [global::ProtoBuf.ProtoMember(10, Name = @"rsig")]
        public byte[] Rsig
        {
            get { return __pbn__Rsig; }
            set { __pbn__Rsig = value; }
        }
        public bool ShouldSerializeRsig() => __pbn__Rsig != null;
        public void ResetRsig() => __pbn__Rsig = null;
        private byte[] __pbn__Rsig;

        [global::ProtoBuf.ProtoMember(11, Name = @"outputs")]
        public global::System.Collections.Generic.List<MoneroTransactionDestinationEntry> Outputs { get; } = new global::System.Collections.Generic.List<MoneroTransactionDestinationEntry>();

    }
}