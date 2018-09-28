namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroWatchKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"watch_key")]
        public byte[] WatchKey { get; set; }
        public bool ShouldSerializeWatchKey() => WatchKey != null;
        public void ResetWatchKey() => WatchKey = null;

        [ProtoBuf.ProtoMember(2, Name = @"address")]
        public byte[] Address { get; set; }
        public bool ShouldSerializeAddress() => Address != null;
        public void ResetAddress() => Address = null;
    }
}