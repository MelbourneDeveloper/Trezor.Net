namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroWatchKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"watch_key")]
        public byte[] WatchKey
        {
            get { return __pbn__WatchKey; }
            set { __pbn__WatchKey = value; }
        }
        public bool ShouldSerializeWatchKey() => __pbn__WatchKey != null;
        public void ResetWatchKey() => __pbn__WatchKey = null;
        private byte[] __pbn__WatchKey;

        [global::ProtoBuf.ProtoMember(2, Name = @"address")]
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