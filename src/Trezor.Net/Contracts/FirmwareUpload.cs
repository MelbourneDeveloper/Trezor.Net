namespace Trezor.Net.Contracts.Bootloader
{
    [ProtoBuf.ProtoContract()]
    public class FirmwareUpload : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"payload", IsRequired = true)]
        public byte[] Payload { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"hash")]
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