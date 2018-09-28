namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class SignedIdentity : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get { return __pbn__Address ?? ""; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

        [global::ProtoBuf.ProtoMember(3, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

    }
}