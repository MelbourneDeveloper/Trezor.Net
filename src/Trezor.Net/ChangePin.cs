using ProtoBuf;

namespace Trezor
{
    public class ChangePin
    {
        [ProtoMember(1, Name = @"remove")]
        public bool Remove
        {
            get => __pbn__Remove.GetValueOrDefault();
            set => __pbn__Remove = value;
        }
        public bool ShouldSerializeRemove() => __pbn__Remove != null;
        public void ResetRemove() => __pbn__Remove = null;
        private bool? __pbn__Remove;

    }
}