namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroWatchKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"watch_key")]
        public byte[] WatchKey
        {
            get { return __pbn__WatchKey; }
            set { __pbn__WatchKey = value; }
        }
        public bool ShouldSerializeWatchKey() => __pbn__WatchKey != null;
        public void ResetWatchKey() => __pbn__WatchKey = null;
        private byte[] __pbn__WatchKey;

        [ProtoBuf.ProtoMember(2, Name = @"address")]
        public byte[] Address
        {
            get { return __pbn__Address; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private byte[] __pbn__Address;

    }
}