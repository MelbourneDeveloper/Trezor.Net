namespace Trezor.Net.Contracts.Lisk
{
    [ProtoBuf.ProtoContract()]
    public class LiskSignMessage : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"message")]
        public byte[] Message { get; set; }
        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;
    }
}