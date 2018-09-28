namespace Trezor.Net.Contracts.Ethereum
{
    [global::ProtoBuf.ProtoContract()]
    public class EthereumAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address", IsRequired = true)]
        public byte[] Address { get; set; }

    }
}