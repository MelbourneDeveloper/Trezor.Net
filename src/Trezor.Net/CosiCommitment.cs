using ProtoBuf;

namespace Trezor
{
    public class CosiCommitment
    {
        [ProtoMember(1, Name = @"commitment")]
        public byte[] Commitment { get; set; }

        public bool ShouldSerializeCommitment() => Commitment != null;
        public void ResetCommitment() => Commitment = null;

        [ProtoMember(2, Name = @"pubkey")]
        public byte[] Pubkey { get; set; }

        public bool ShouldSerializePubkey() => Pubkey != null;
        public void ResetPubkey() => Pubkey = null;
    }
}