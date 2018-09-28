namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroGetWatchKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"network_type")]
        public uint NetworkType
        {
            get { return __pbn__NetworkType.GetValueOrDefault(); }
            set { __pbn__NetworkType = value; }
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

    }
}