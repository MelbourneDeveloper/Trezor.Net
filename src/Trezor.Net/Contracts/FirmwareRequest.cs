namespace Trezor.Net.Contracts.Bootloader
{
    [ProtoBuf.ProtoContract()]
    public class FirmwareRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"offset")]
        public uint Offset
        {
            get { return __pbn__Offset.GetValueOrDefault(); }
            set { __pbn__Offset = value; }
        }
        public bool ShouldSerializeOffset() => __pbn__Offset != null;
        public void ResetOffset() => __pbn__Offset = null;
        private uint? __pbn__Offset;

        [ProtoBuf.ProtoMember(2, Name = @"length")]
        public uint Length
        {
            get { return __pbn__Length.GetValueOrDefault(); }
            set { __pbn__Length = value; }
        }
        public bool ShouldSerializeLength() => __pbn__Length != null;
        public void ResetLength() => __pbn__Length = null;
        private uint? __pbn__Length;

    }
}