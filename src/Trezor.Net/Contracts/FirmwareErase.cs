using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class FirmwareErase
    {
        [ProtoMember(1, Name = @"length")]
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