namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class Entropy : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, IsRequired = true)]
        public byte[] entropy { get; set; }

    }
}