namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetOutputAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tx_out")]
        public byte[] TxOut { get; set; }
        public bool ShouldSerializeTxOut() => TxOut != null;
        public void ResetTxOut() => TxOut = null;

        [ProtoBuf.ProtoMember(2, Name = @"vouti_hmac")]
        public byte[] VoutiHmac { get; set; }
        public bool ShouldSerializeVoutiHmac() => VoutiHmac != null;
        public void ResetVoutiHmac() => VoutiHmac = null;

        [ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"out_pk")]
        public byte[] OutPk { get; set; }
        public bool ShouldSerializeOutPk() => OutPk != null;
        public void ResetOutPk() => OutPk = null;

        [ProtoBuf.ProtoMember(5, Name = @"ecdh_info")]
        public byte[] EcdhInfo { get; set; }
        public bool ShouldSerializeEcdhInfo() => EcdhInfo != null;
        public void ResetEcdhInfo() => EcdhInfo = null;
    }
}