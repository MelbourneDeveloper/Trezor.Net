using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DebugLinkMemory
    {
        [ProtoMember(1, Name = @"memory")]
        public byte[] Memory { get; set; }

        public bool ShouldSerializeMemory() => Memory != null;
        public void ResetMemory() => Memory = null;
    }
}