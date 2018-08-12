using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EthereumVerifyMessage
    {
        [ProtoMember(1, Name = @"address")]
        public byte[] Address { get; set; }

        public bool ShouldSerializeAddress() => Address != null;
        public void ResetAddress() => Address = null;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;

        [ProtoMember(3, Name = @"message")]
        public byte[] Message { get; set; }

        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;
    }
}