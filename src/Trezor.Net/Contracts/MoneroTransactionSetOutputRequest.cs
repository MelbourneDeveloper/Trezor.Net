namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetOutputRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"dst_entr")]
        public MoneroTransactionDestinationEntry DstEntr { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"dst_entr_hmac")]
        public byte[] DstEntrHmac
        {
            get { return __pbn__DstEntrHmac; }
            set { __pbn__DstEntrHmac = value; }
        }
        public bool ShouldSerializeDstEntrHmac() => __pbn__DstEntrHmac != null;
        public void ResetDstEntrHmac() => __pbn__DstEntrHmac = null;
        private byte[] __pbn__DstEntrHmac;

        [global::ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}