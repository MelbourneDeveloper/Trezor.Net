namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class SignedIdentity : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address")]
        [System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get => __pbn__Address ?? "";
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [ProtoBuf.ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey { get; set; }
        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;

        [ProtoBuf.ProtoMember(3, Name = @"signature")]
        public byte[] Signature { get; set; }
        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;
    }
}