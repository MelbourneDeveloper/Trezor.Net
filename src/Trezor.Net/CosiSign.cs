using ProtoBuf;

namespace Trezor
{
    public class CosiSign
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        public bool ShouldSerializeData() => Data != null;
        public void ResetData() => Data = null;

        [ProtoMember(3, Name = @"global_commitment")]
        public byte[] GlobalCommitment { get; set; }

        public bool ShouldSerializeGlobalCommitment() => GlobalCommitment != null;
        public void ResetGlobalCommitment() => GlobalCommitment = null;

        [ProtoMember(4, Name = @"global_pubkey")]
        public byte[] GlobalPubkey { get; set; }

        public bool ShouldSerializeGlobalPubkey() => GlobalPubkey != null;
        public void ResetGlobalPubkey() => GlobalPubkey = null;
    }
}