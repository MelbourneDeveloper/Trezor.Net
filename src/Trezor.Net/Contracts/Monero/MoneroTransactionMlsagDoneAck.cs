namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionMlsagDoneAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"full_message_hash")]
        public byte[] FullMessageHash { get; set; }
        public bool ShouldSerializeFullMessageHash() => FullMessageHash != null;
        public void ResetFullMessageHash() => FullMessageHash = null;
    }
}