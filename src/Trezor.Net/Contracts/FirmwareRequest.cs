namespace Trezor.Net.Contracts.Bootloader
{
    [global::ProtoBuf.ProtoContract()]
    public class FirmwareRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"offset")]
        public uint Offset
        {
            get { return __pbn__Offset.GetValueOrDefault(); }
            set { __pbn__Offset = value; }
        }
        public bool ShouldSerializeOffset() => __pbn__Offset != null;
        public void ResetOffset() => __pbn__Offset = null;
        private uint? __pbn__Offset;

        [global::ProtoBuf.ProtoMember(2, Name = @"length")]
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