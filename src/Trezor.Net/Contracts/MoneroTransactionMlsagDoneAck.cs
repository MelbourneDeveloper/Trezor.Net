namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionMlsagDoneAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"full_message_hash")]
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