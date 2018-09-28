namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroGetAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

        [global::ProtoBuf.ProtoMember(3, Name = @"network_type")]
        public uint NetworkType
        {
            get { return __pbn__NetworkType.GetValueOrDefault(); }
            set { __pbn__NetworkType = value; }
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [global::ProtoBuf.ProtoMember(4, Name = @"account")]
        public uint Account
        {
            get { return __pbn__Account.GetValueOrDefault(); }
            set { __pbn__Account = value; }
        }
        public bool ShouldSerializeAccount() => __pbn__Account != null;
        public void ResetAccount() => __pbn__Account = null;
        private uint? __pbn__Account;

        [global::ProtoBuf.ProtoMember(5, Name = @"minor")]
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