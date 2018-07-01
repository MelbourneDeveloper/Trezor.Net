using ProtoBuf;

namespace Trezor
{
    public class Entropy
    {
        [ProtoMember(1, IsRequired = true)]
        public byte[] entropy { get; set; }

    }
}