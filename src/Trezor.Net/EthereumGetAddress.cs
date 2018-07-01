using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EthereumGetAddress
    {
        #region Fields
        private bool? __pbn__ShowDisplay;
        #endregion

        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get => __pbn__ShowDisplay.GetValueOrDefault();
            set => __pbn__ShowDisplay = value;
        }

        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;

    }
}