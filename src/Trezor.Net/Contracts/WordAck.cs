namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class WordAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"word", IsRequired = true)]
        public string Word { get; set; }

    }
}