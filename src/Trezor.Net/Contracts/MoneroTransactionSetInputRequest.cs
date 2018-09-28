namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetInputRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"version")]
        public uint Version
        {
            get { return __pbn__Version.GetValueOrDefault(); }
            set { __pbn__Version = value; }
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoBuf.ProtoMember(2, Name = @"src_entr")]
        public MoneroTransactionSourceEntry SrcEntr { get; set; }

    }
}