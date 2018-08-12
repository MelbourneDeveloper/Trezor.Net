using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class TxSize
    {
        [ProtoMember(1)]
        public uint tx_size
        {
            get => __pbn__tx_size.GetValueOrDefault();
            set => __pbn__tx_size = value;
        }
        public bool ShouldSerializetx_size() => __pbn__tx_size != null;
        public void Resettx_size() => __pbn__tx_size = null;
        private uint? __pbn__tx_size;

    }
}