using ProtoBuf;

namespace Trezor
{
    public class EncryptedMessage 
    {
        [ProtoMember(1, Name = @"nonce")]
        public byte[] Nonce { get; set; }

        public bool ShouldSerializeNonce() => Nonce != null;
        public void ResetNonce() => Nonce = null;

        [ProtoMember(2, Name = @"message")]
        public byte[] Message { get; set; }

        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;

        [ProtoMember(3, Name = @"hmac")]
        public byte[] Hmac { get; set; }

        public bool ShouldSerializeHmac() => Hmac != null;
        public void ResetHmac() => Hmac = null;
    }
}