namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class ECDHSessionKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"session_key")]
        public byte[] SessionKey
        {
            get { return __pbn__SessionKey; }
            set { __pbn__SessionKey = value; }
        }
        public bool ShouldSerializeSessionKey() => __pbn__SessionKey != null;
        public void ResetSessionKey() => __pbn__SessionKey = null;
        private byte[] __pbn__SessionKey;

    }
}