namespace Trezor.Net.Contracts.Debug
{
    [ProtoBuf.ProtoContract()]
    public class DebugLinkMemoryWrite : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address")]
        public uint Address
        {
            get { return __pbn__Address.GetValueOrDefault(); }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private uint? __pbn__Address;

        [ProtoBuf.ProtoMember(2, Name = @"memory")]
        public byte[] Memory
        {
            get { return __pbn__Memory; }
            set { __pbn__Memory = value; }
        }
        public bool ShouldSerializeMemory() => __pbn__Memory != null;
        public void ResetMemory() => __pbn__Memory = null;
        private byte[] __pbn__Memory;

        [ProtoBuf.ProtoMember(3, Name = @"flash")]
        public bool Flash
        {
            get { return __pbn__Flash.GetValueOrDefault(); }
            set { __pbn__Flash = value; }
        }
        public bool ShouldSerializeFlash() => __pbn__Flash != null;
        public void ResetFlash() => __pbn__Flash = null;
        private bool? __pbn__Flash;

    }
}