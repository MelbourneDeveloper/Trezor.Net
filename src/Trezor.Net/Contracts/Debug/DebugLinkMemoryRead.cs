namespace Trezor.Net.Contracts.Debug
{
    [ProtoBuf.ProtoContract()]
    public class DebugLinkMemoryRead : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address")]
        public uint Address
        {
            get => __pbn__Address.GetValueOrDefault();
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private uint? __pbn__Address;

        [ProtoBuf.ProtoMember(2, Name = @"length")]
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