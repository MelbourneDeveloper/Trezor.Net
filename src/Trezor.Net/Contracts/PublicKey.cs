namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public class PublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"node", IsRequired = true)]
        public global::Trezor.Net.Contracts.Common.HDNodeType Node { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"xpub")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Xpub
        {
            get { return __pbn__Xpub ?? ""; }
            set { __pbn__Xpub = value; }
        }
        public bool ShouldSerializeXpub() => __pbn__Xpub != null;
        public void ResetXpub() => __pbn__Xpub = null;
        private string __pbn__Xpub;

    }
}