namespace Trezor.Net.Contracts.NEM
{
    [ProtoBuf.ProtoContract()]
    public class NEMAddress : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address", IsRequired = true)]
        public string Address { get; set; }

    }
}