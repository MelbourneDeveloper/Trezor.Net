namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionMlsagDoneAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"full_message_hash")]
        public byte[] FullMessageHash
        {
            get { return __pbn__FullMessageHash; }
            set { __pbn__FullMessageHash = value; }
        }
        public bool ShouldSerializeFullMessageHash() => __pbn__FullMessageHash != null;
        public void ResetFullMessageHash() => __pbn__FullMessageHash = null;
        private byte[] __pbn__FullMessageHash;

    }
}