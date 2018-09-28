namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class WordAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"word", IsRequired = true)]
        public string Word { get; set; }

    }
}