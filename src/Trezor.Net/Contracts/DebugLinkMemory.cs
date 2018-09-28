namespace Trezor.Net.Contracts.Debug
{
    [ProtoBuf.ProtoContract()]
    public class DebugLinkMemory : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"memory")]
        public byte[] Memory
        {
            get { return __pbn__Memory; }
            set { __pbn__Memory = value; }
        }
        public bool ShouldSerializeMemory() => __pbn__Memory != null;
        public void ResetMemory() => __pbn__Memory = null;
        private byte[] __pbn__Memory;

    }
}