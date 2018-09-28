namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class GetEntropy : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"size", IsRequired = true)]
        public uint Size { get; set; }

    }
}