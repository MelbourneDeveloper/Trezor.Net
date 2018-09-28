namespace Trezor.Net.Contracts.Debug
{
    [ProtoBuf.ProtoContract()]
    public class DebugLinkFlashErase : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"sector")]
        public uint Sector
        {
            get => __pbn__Sector.GetValueOrDefault();
            set => __pbn__Sector = value;
        }
        public bool ShouldSerializeSector() => __pbn__Sector != null;
        public void ResetSector() => __pbn__Sector = null;
        private uint? __pbn__Sector;

    }
}