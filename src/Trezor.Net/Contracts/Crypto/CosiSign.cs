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
        public byte[] Data { get; set; }
        public bool ShouldSerializeData() => Data != null;
        public void ResetData() => Data = null;

        [ProtoBuf.ProtoMember(3, Name = @"global_commitment")]
        public byte[] GlobalCommitment { get; set; }
        public bool ShouldSerializeGlobalCommitment() => GlobalCommitment != null;
        public void ResetGlobalCommitment() => GlobalCommitment = null;

        [ProtoBuf.ProtoMember(4, Name = @"global_pubkey")]
        public byte[] GlobalPubkey { get; set; }
        public bool ShouldSerializeGlobalPubkey() => GlobalPubkey != null;
        public void ResetGlobalPubkey() => GlobalPubkey = null;
    }
}