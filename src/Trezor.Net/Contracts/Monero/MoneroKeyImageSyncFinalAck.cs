namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncFinalAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"enc_key")]
        public byte[] EncKey { get; set; }
        public bool ShouldSerializeEncKey() => EncKey != null;
        public void ResetEncKey() => EncKey = null;
    }
}