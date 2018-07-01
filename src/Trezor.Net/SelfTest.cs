using ProtoBuf;

namespace Trezor
{
    public class SelfTest
    {
        [ProtoMember(1, Name = @"payload")]
        public byte[] Payload { get; set; }

        public bool ShouldSerializePayload() => Payload != null;
        public void ResetPayload() => Payload = null;
    }
}