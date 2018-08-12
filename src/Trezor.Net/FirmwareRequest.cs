using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class FirmwareRequest
    {
        [ProtoMember(1, Name = @"offset")]
        public uint Offset
        {
            get => __pbn__Offset.GetValueOrDefault();
            set => __pbn__Offset = value;
        }
        public bool ShouldSerializeOffset() => __pbn__Offset != null;
        public void ResetOffset() => __pbn__Offset = null;
        private uint? __pbn__Offset;

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