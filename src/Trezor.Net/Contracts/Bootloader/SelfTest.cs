namespace Trezor.Net.Contracts.Bootloader
{
    [ProtoBuf.ProtoContract()]
    public class SelfTest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"payload")]
        public byte[] Payload { get; set; }
        public bool ShouldSerializePayload() => Payload != null;
        public void ResetPayload() => Payload = null;
    }
}