using ProtoBuf;

namespace Trezor
{
    public class NEMSignedTx
    {
        [ProtoMember(1, Name = @"data")]
        public byte[] Data { get; set; }

        public bool ShouldSerializeData() => Data != null;
        public void ResetData() => Data = null;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;
    }
}