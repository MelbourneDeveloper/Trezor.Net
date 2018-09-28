namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class ApplyFlags : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"flags")]
        public uint Flags
        {
            get => __pbn__Flags.GetValueOrDefault();
            set => __pbn__Flags = value;
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

    }
}