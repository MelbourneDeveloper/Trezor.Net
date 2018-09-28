namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class CosiCommitment : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"commitment")]
        public byte[] Commitment { get; set; }
        public bool ShouldSerializeCommitment() => Commitment != null;
        public void ResetCommitment() => Commitment = null;

        [ProtoBuf.ProtoMember(2, Name = @"pubkey")]
        public byte[] Pubkey { get; set; }
        public bool ShouldSerializePubkey() => Pubkey != null;
        public void ResetPubkey() => Pubkey = null;
    }
}