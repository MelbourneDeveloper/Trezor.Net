namespace Trezor.Net.Contracts.Bootloader
{
    [global::ProtoBuf.ProtoContract()]
    public class FirmwareUpload : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"payload", IsRequired = true)]
        public byte[] Payload { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"hash")]
        public byte[] Hash
        {
            get { return __pbn__Hash; }
            set { __pbn__Hash = value; }
        }
        public bool ShouldSerializeHash() => __pbn__Hash != null;
        public void ResetHash() => __pbn__Hash = null;
        private byte[] __pbn__Hash;

    }
}