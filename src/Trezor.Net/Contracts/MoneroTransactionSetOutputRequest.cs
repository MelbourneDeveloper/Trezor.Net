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
        public byte[] DstEntrHmac { get; set; }
        public bool ShouldSerializeDstEntrHmac() => DstEntrHmac != null;
        public void ResetDstEntrHmac() => DstEntrHmac = null;

        [ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}