using ProtoBuf;

namespace Trezor
{
    public class DebugLinkMemoryWrite
    {
        [ProtoMember(1, Name = @"address")]
        public uint Address
        {
            get => __pbn__Address.GetValueOrDefault();
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private uint? __pbn__Address;

        [ProtoMember(2, Name = @"memory")]
        public byte[] Memory { get; set; }

        public bool ShouldSerializeMemory() => Memory != null;
        public void ResetMemory() => Memory = null;

        [ProtoMember(3, Name = @"flash")]
        public bool Flash
        {
            get => __pbn__Flash.GetValueOrDefault();
            set => __pbn__Flash = value;
        }
        public bool ShouldSerializeFlash() => __pbn__Flash != null;
        public void ResetFlash() => __pbn__Flash = null;
        private bool? __pbn__Flash;

    }
}