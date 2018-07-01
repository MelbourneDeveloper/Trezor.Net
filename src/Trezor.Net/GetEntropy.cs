using ProtoBuf;

namespace Trezor
{
    public class GetEntropy
    {
        [ProtoMember(1, Name = @"size", IsRequired = true)]
        public uint Size { get; set; }

    }
}