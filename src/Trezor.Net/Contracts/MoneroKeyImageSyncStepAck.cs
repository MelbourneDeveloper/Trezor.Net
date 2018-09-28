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
            public byte[] Iv
            {
                get { return __pbn__Iv; }
                set { __pbn__Iv = value; }
            }
            public bool ShouldSerializeIv() => __pbn__Iv != null;
            public void ResetIv() => __pbn__Iv = null;
            private byte[] __pbn__Iv;

            [ProtoBuf.ProtoMember(2, Name = @"tag")]
            public byte[] Tag
            {
                get { return __pbn__Tag; }
                set { __pbn__Tag = value; }
            }
            public bool ShouldSerializeTag() => __pbn__Tag != null;
            public void ResetTag() => __pbn__Tag = null;
            private byte[] __pbn__Tag;

            [ProtoBuf.ProtoMember(3, Name = @"blob")]
            public byte[] Blob
            {
                get { return __pbn__Blob; }
                set { __pbn__Blob = value; }
            }
            public bool ShouldSerializeBlob() => __pbn__Blob != null;
            public void ResetBlob() => __pbn__Blob = null;
            private byte[] __pbn__Blob;

        }

    }
}