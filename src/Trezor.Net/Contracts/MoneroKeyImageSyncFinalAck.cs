namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncFinalAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"enc_key")]
        public byte[] EncKey
        {
            get { return __pbn__EncKey; }
            set { __pbn__EncKey = value; }
        }
        public bool ShouldSerializeEncKey() => __pbn__EncKey != null;
        public void ResetEncKey() => __pbn__EncKey = null;
        private byte[] __pbn__EncKey;

    }
}