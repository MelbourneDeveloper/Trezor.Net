namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class PinMatrixAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"pin", IsRequired = true)]
        public string Pin { get; set; }

    }
}