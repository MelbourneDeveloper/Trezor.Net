namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionInitAck : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"status")]
        public uint Status
        {
            get { return __pbn__Status.GetValueOrDefault(); }
            set { __pbn__Status = value; }
        }
        public bool ShouldSerializeStatus() => __pbn__Status != null;
        public void ResetStatus() => __pbn__Status = null;
        private uint? __pbn__Status;

        [global::ProtoBuf.ProtoMember(3, Name = @"in_memory")]
        public bool InMemory
        {
            get { return __pbn__InMemory.GetValueOrDefault(); }
            set { __pbn__InMemory = value; }
        }
        public bool ShouldSerializeInMemory() => __pbn__InMemory != null;
        public void ResetInMemory() => __pbn__InMemory = null;
        private bool? __pbn__InMemory;

        [global::ProtoBuf.ProtoMember(4, Name = @"hmacs")]
        public global::System.Collections.Generic.List<byte[]> Hmacs { get; } = new global::System.Collections.Generic.List<byte[]>();

        [global::ProtoBuf.ProtoMember(5, Name = @"many_inputs")]
        public bool ManyInputs
        {
            get { return __pbn__ManyInputs.GetValueOrDefault(); }
            set { __pbn__ManyInputs = value; }
        }
        public bool ShouldSerializeManyInputs() => __pbn__ManyInputs != null;
        public void ResetManyInputs() => __pbn__ManyInputs = null;
        private bool? __pbn__ManyInputs;

        [global::ProtoBuf.ProtoMember(6, Name = @"many_outputs")]
        public bool ManyOutputs
        {
            get { return __pbn__ManyOutputs.GetValueOrDefault(); }
            set { __pbn__ManyOutputs = value; }
        }
        public bool ShouldSerializeManyOutputs() => __pbn__ManyOutputs != null;
        public void ResetManyOutputs() => __pbn__ManyOutputs = null;
        private bool? __pbn__ManyOutputs;

        [global::ProtoBuf.ProtoMember(7, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}