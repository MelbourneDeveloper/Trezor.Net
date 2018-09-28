namespace Trezor.Net.Contracts.Debug
{
    [global::ProtoBuf.ProtoContract()]
    public class DebugLinkMemory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"memory")]
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