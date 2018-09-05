using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DebugLinkFlashErase
    {
        [ProtoMember(1, Name = @"sector")]
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