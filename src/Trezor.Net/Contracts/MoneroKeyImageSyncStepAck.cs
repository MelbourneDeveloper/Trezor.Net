namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncStepAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"kis")]
        public System.Collections.Generic.List<MoneroExportedKeyImage> Kes { get; } = new System.Collections.Generic.List<MoneroExportedKeyImage>();

        [ProtoBuf.ProtoContract()]
        public class MoneroExportedKeyImage : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"iv")]
            public byte[] Iv { get; set; }
            public bool ShouldSerializeIv() => Iv != null;
            public void ResetIv() => Iv = null;

            [ProtoBuf.ProtoMember(2, Name = @"tag")]
            public byte[] Tag { get; set; }
            public bool ShouldSerializeTag() => Tag != null;
            public void ResetTag() => Tag = null;

            [ProtoBuf.ProtoMember(3, Name = @"blob")]
            public byte[] Blob { get; set; }
            public bool ShouldSerializeBlob() => Blob != null;
            public void ResetBlob() => Blob = null;
        }

    }
}