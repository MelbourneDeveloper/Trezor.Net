using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class DebugLinkMemoryRead
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

        [ProtoMember(2, Name = @"length")]
        public uint Length
        {
            get => __pbn__Length.GetValueOrDefault();
            set => __pbn__Length = value;
        }
        public bool ShouldSerializeLength() => __pbn__Length != null;
        public void ResetLength() => __pbn__Length = null;
        private uint? __pbn__Length;

    }
}