using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class HDNodeType
    {
        [ProtoMember(1, Name = @"depth", IsRequired = true)]
        public uint Depth { get; set; }

        [ProtoMember(2, Name = @"fingerprint", IsRequired = true)]
        public uint Fingerprint { get; set; }

        [ProtoMember(3, Name = @"child_num", IsRequired = true)]
        public uint ChildNum { get; set; }

        [ProtoMember(4, Name = @"chain_code", IsRequired = true)]
        public byte[] ChainCode { get; set; }

        [ProtoMember(5, Name = @"private_key")]
        public byte[] PrivateKey { get; set; }

        public bool ShouldSerializePrivateKey() => PrivateKey != null;
        public void ResetPrivateKey() => PrivateKey = null;

        [ProtoMember(6, Name = @"public_key")]
        public byte[] PublicKey { get; set; }

        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;
    }
}