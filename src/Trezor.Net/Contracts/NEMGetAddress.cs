using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMGetAddress
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"network")]
        public uint Network
        {
            get => __pbn__Network.GetValueOrDefault();
            set => __pbn__Network = value;
        }
        public bool ShouldSerializeNetwork() => __pbn__Network != null;
        public void ResetNetwork() => __pbn__Network = null;
        private uint? __pbn__Network;

        [ProtoMember(3, Name = @"show_display")]
        public bool ShowDisplay
        {
            get => __pbn__ShowDisplay.GetValueOrDefault();
            set => __pbn__ShowDisplay = value;
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

    }
}