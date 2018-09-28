namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroGetAddress : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

        [ProtoBuf.ProtoMember(3, Name = @"network_type")]
        public uint NetworkType
        {
            get { return __pbn__NetworkType.GetValueOrDefault(); }
            set { __pbn__NetworkType = value; }
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [ProtoBuf.ProtoMember(4, Name = @"account")]
        public uint Account
        {
            get { return __pbn__Account.GetValueOrDefault(); }
            set { __pbn__Account = value; }
        }
        public bool ShouldSerializeAccount() => __pbn__Account != null;
        public void ResetAccount() => __pbn__Account = null;
        private uint? __pbn__Account;

        [ProtoBuf.ProtoMember(5, Name = @"minor")]
        public uint Minor
        {
            get { return __pbn__Minor.GetValueOrDefault(); }
            set { __pbn__Minor = value; }
        }
        public bool ShouldSerializeMinor() => __pbn__Minor != null;
        public void ResetMinor() => __pbn__Minor = null;
        private uint? __pbn__Minor;

    }
}