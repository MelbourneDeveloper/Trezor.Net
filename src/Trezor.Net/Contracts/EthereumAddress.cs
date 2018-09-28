namespace Trezor.Net.Contracts.Ethereum
{
    [ProtoBuf.ProtoContract()]
    public class EthereumAddress : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address", IsRequired = true)]
        public byte[] Address { get; set; }

    }
}