namespace Trezor.Net.Contracts.Cardano
{
    [global::ProtoBuf.ProtoContract()]
    public class CardanoPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"xpub")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Xpub
        {
            get { return __pbn__Xpub ?? ""; }
            set { __pbn__Xpub = value; }
        }
        public bool ShouldSerializeXpub() => __pbn__Xpub != null;
        public void ResetXpub() => __pbn__Xpub = null;
        private string __pbn__Xpub;

        [global::ProtoBuf.ProtoMember(2, Name = @"node")]
        public global::Trezor.Net.Contracts.Common.HDNodeType Node { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"root_hd_passphrase")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RootHdPassphrase
        {
            get { return __pbn__RootHdPassphrase ?? ""; }
            set { __pbn__RootHdPassphrase = value; }
        }
        public bool ShouldSerializeRootHdPassphrase() => __pbn__RootHdPassphrase != null;
        public void ResetRootHdPassphrase() => __pbn__RootHdPassphrase = null;
        private string __pbn__RootHdPassphrase;

    }
}