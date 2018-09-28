namespace Trezor.Net.Contracts.Bootloader
{
    [global::ProtoBuf.ProtoContract()]
    public class SelfTest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"payload")]
        public byte[] Payload
        {
            get { return __pbn__Payload; }
            set { __pbn__Payload = value; }
        }
        public bool ShouldSerializePayload() => __pbn__Payload != null;
        public void ResetPayload() => __pbn__Payload = null;
        private byte[] __pbn__Payload;

    }
}