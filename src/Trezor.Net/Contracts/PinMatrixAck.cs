namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class PinMatrixAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pin", IsRequired = true)]
        public string Pin { get; set; }

    }
}