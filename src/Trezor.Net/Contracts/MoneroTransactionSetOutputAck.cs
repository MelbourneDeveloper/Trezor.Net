namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetOutputAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tx_out")]
        public byte[] TxOut
        {
            get { return __pbn__TxOut; }
            set { __pbn__TxOut = value; }
        }
        public bool ShouldSerializeTxOut() => __pbn__TxOut != null;
        public void ResetTxOut() => __pbn__TxOut = null;
        private byte[] __pbn__TxOut;

        [ProtoBuf.ProtoMember(2, Name = @"vouti_hmac")]
        public byte[] VoutiHmac
        {
            get { return __pbn__VoutiHmac; }
            set { __pbn__VoutiHmac = value; }
        }
        public bool ShouldSerializeVoutiHmac() => __pbn__VoutiHmac != null;
        public void ResetVoutiHmac() => __pbn__VoutiHmac = null;
        private byte[] __pbn__VoutiHmac;

        [ProtoBuf.ProtoMember(3, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"out_pk")]
        public byte[] OutPk
        {
            get { return __pbn__OutPk; }
            set { __pbn__OutPk = value; }
        }
        public bool ShouldSerializeOutPk() => __pbn__OutPk != null;
        public void ResetOutPk() => __pbn__OutPk = null;
        private byte[] __pbn__OutPk;

        [ProtoBuf.ProtoMember(5, Name = @"ecdh_info")]
        public byte[] EcdhInfo
        {
            get { return __pbn__EcdhInfo; }
            set { __pbn__EcdhInfo = value; }
        }
        public bool ShouldSerializeEcdhInfo() => __pbn__EcdhInfo != null;
        public void ResetEcdhInfo() => __pbn__EcdhInfo = null;
        private byte[] __pbn__EcdhInfo;

    }
}