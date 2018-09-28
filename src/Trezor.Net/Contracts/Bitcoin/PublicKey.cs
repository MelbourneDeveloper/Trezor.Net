namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public class PublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"node", IsRequired = true)]
        public Common.HDNodeType Node { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"xpub")]
        [System.ComponentModel.DefaultValue("")]
        public string Xpub
        {
            get => __pbn__Xpub ?? "";
            set => __pbn__Xpub = value;
        }
        public bool ShouldSerializeXpub() => __pbn__Xpub != null;
        public void ResetXpub() => __pbn__Xpub = null;
        private string __pbn__Xpub;

    }
}