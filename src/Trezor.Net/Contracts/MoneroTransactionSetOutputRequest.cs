namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetOutputRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"dst_entr")]
        public MoneroTransactionDestinationEntry DstEntr { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"dst_entr_hmac")]
        public byte[] DstEntrHmac
        {
            get { return __pbn__DstEntrHmac; }
            set { __pbn__DstEntrHmac = value; }
        }
        public bool ShouldSerializeDstEntrHmac() => __pbn__DstEntrHmac != null;
        public void ResetDstEntrHmac() => __pbn__DstEntrHmac = null;
        private byte[] __pbn__DstEntrHmac;

        [ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}