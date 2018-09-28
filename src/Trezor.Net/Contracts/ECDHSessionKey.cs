namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class ECDHSessionKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"session_key")]
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