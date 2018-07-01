using ProtoBuf;

namespace Trezor
{
    public class CipheredKeyValue
    {
        [ProtoMember(1, Name = @"value")]
        public byte[] Value { get; set; }

        public bool ShouldSerializeValue() => Value != null;
        public void ResetValue() => Value = null;
    }
}