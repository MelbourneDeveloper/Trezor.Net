namespace Trezor.Net.Contracts.Tezos
{
    [ProtoBuf.ProtoContract()]
    public class TezosPublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"public_key")]
        [System.ComponentModel.DefaultValue("")]
        public string PublicKey
        {
            get { return __pbn__PublicKey ?? ""; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private string __pbn__PublicKey;

    }
}