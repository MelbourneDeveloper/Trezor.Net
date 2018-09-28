namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncFinalAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"enc_key")]
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