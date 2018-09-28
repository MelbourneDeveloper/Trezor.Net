namespace Trezor.Net.Contracts.Cardano
{
    [ProtoBuf.ProtoContract()]
    public class CardanoPublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"xpub")]
        [System.ComponentModel.DefaultValue("")]
        public string Xpub
        {
            get => __pbn__Xpub ?? "";
            set => __pbn__Xpub = value;
        }
        public bool ShouldSerializeXpub() => __pbn__Xpub != null;
        public void ResetXpub() => __pbn__Xpub = null;
        private string __pbn__Xpub;

        [ProtoBuf.ProtoMember(2, Name = @"node")]
        public Common.HDNodeType Node { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"root_hd_passphrase")]
        [System.ComponentModel.DefaultValue("")]
        public string RootHdPassphrase
        {
            get => __pbn__RootHdPassphrase ?? "";
            set => __pbn__RootHdPassphrase = value;
        }
        public bool ShouldSerializeRootHdPassphrase() => __pbn__RootHdPassphrase != null;
        public void ResetRootHdPassphrase() => __pbn__RootHdPassphrase = null;
        private string __pbn__RootHdPassphrase;

    }
}