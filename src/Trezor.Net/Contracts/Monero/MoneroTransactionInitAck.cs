namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionInitAck : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"status")]
        public uint Status
        {
            get => __pbn__Status.GetValueOrDefault();
            set => __pbn__Status = value;
        }
        public bool ShouldSerializeStatus() => __pbn__Status != null;
        public void ResetStatus() => __pbn__Status = null;
        private uint? __pbn__Status;

        [ProtoBuf.ProtoMember(3, Name = @"in_memory")]
        public bool InMemory
        {
            get => __pbn__InMemory.GetValueOrDefault();
            set => __pbn__InMemory = value;
        }
        public bool ShouldSerializeInMemory() => __pbn__InMemory != null;
        public void ResetInMemory() => __pbn__InMemory = null;
        private bool? __pbn__InMemory;

        [ProtoBuf.ProtoMember(4, Name = @"hmacs")]
        public System.Collections.Generic.List<byte[]> Hmacs { get; } = new System.Collections.Generic.List<byte[]>();

        [ProtoBuf.ProtoMember(5, Name = @"many_inputs")]
        public bool ManyInputs
        {
            get => __pbn__ManyInputs.GetValueOrDefault();
            set => __pbn__ManyInputs = value;
        }
        public bool ShouldSerializeManyInputs() => __pbn__ManyInputs != null;
        public void ResetManyInputs() => __pbn__ManyInputs = null;
        private bool? __pbn__ManyInputs;

        [ProtoBuf.ProtoMember(6, Name = @"many_outputs")]
        public bool ManyOutputs
        {
            get => __pbn__ManyOutputs.GetValueOrDefault();
            set => __pbn__ManyOutputs = value;
        }
        public bool ShouldSerializeManyOutputs() => __pbn__ManyOutputs != null;
        public void ResetManyOutputs() => __pbn__ManyOutputs = null;
        private bool? __pbn__ManyOutputs;

        [ProtoBuf.ProtoMember(7, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}