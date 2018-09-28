namespace Trezor.Net.Contracts.Lisk
{
    [ProtoBuf.ProtoContract()]
    public class LiskPublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"public_key")]
        public byte[] PublicKey { get; set; }
        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;
    }
}