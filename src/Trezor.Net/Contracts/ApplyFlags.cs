using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class ApplyFlags
    {
        [ProtoMember(1, Name = @"flags")]
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