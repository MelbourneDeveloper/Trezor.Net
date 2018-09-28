namespace Trezor.Net.Contracts.Debug
{
    [global::ProtoBuf.ProtoContract()]
    public class DebugLinkFlashErase : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sector")]
        public uint Sector
        {
            get { return __pbn__Sector.GetValueOrDefault(); }
            set { __pbn__Sector = value; }
        }
        public bool ShouldSerializeSector() => __pbn__Sector != null;
        public void ResetSector() => __pbn__Sector = null;
        private uint? __pbn__Sector;

    }
}