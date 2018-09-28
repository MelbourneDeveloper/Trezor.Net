namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class CosiSign : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data
        {
            get { return __pbn__Data; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private byte[] __pbn__Data;

        [ProtoBuf.ProtoMember(3, Name = @"global_commitment")]
        public byte[] GlobalCommitment
        {
            get { return __pbn__GlobalCommitment; }
            set { __pbn__GlobalCommitment = value; }
        }
        public bool ShouldSerializeGlobalCommitment() => __pbn__GlobalCommitment != null;
        public void ResetGlobalCommitment() => __pbn__GlobalCommitment = null;
        private byte[] __pbn__GlobalCommitment;

        [ProtoBuf.ProtoMember(4, Name = @"global_pubkey")]
        public byte[] GlobalPubkey
        {
            get { return __pbn__GlobalPubkey; }
            set { __pbn__GlobalPubkey = value; }
        }
        public bool ShouldSerializeGlobalPubkey() => __pbn__GlobalPubkey != null;
        public void ResetGlobalPubkey() => __pbn__GlobalPubkey = null;
        private byte[] __pbn__GlobalPubkey;

    }
}