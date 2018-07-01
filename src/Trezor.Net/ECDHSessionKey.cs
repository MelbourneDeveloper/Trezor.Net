using ProtoBuf;

namespace Trezor
{
    public class ECDHSessionKey
    {
        [ProtoMember(1, Name = @"session_key")]
        public byte[] SessionKey { get; set; }

        public bool ShouldSerializeSessionKey() => SessionKey != null;
        public void ResetSessionKey() => SessionKey = null;
    }
}