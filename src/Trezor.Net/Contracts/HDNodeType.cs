namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class HDNodeType : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"depth", IsRequired = true)]
        public uint Depth { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"fingerprint", IsRequired = true)]
        public uint Fingerprint { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"child_num", IsRequired = true)]
        public uint ChildNum { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"chain_code", IsRequired = true)]
        public byte[] ChainCode { get; set; }

        [ProtoBuf.ProtoMember(5, Name = @"private_key")]
        public byte[] PrivateKey
        {
            get { return __pbn__PrivateKey; }
            set { __pbn__PrivateKey = value; }
        }
        public bool ShouldSerializePrivateKey() => __pbn__PrivateKey != null;
        public void ResetPrivateKey() => __pbn__PrivateKey = null;
        private byte[] __pbn__PrivateKey;

        [ProtoBuf.ProtoMember(6, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

    }
}