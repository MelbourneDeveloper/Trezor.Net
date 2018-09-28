namespace Trezor.Net.Contracts.Tezos
{
    [global::ProtoBuf.ProtoContract()]
    public class TezosPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
        [global::System.ComponentModel.DefaultValue("")]
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