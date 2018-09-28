using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DecryptMessage
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"nonce")]
        public byte[] Nonce { get; set; }

        public bool ShouldSerializeNonce() => Nonce != null;
        public void ResetNonce() => Nonce = null;

        [ProtoMember(3, Name = @"message")]
        public byte[] Message { get; set; }

        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;

        [ProtoMember(4, Name = @"hmac")]
        public byte[] Hmac { get; set; }

        public bool ShouldSerializeHmac() => Hmac != null;
        public void ResetHmac() => Hmac = null;
    }
}