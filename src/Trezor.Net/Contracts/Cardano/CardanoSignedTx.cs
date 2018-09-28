namespace Trezor.Net.Contracts.Cardano
{
    [ProtoBuf.ProtoContract()]
    public class CardanoSignedTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tx_hash")]
        public byte[] TxHash
        {
            get { return __pbn__TxHash; }
            set { __pbn__TxHash = value; }
        }
        public bool ShouldSerializeTxHash() => __pbn__TxHash != null;
        public void ResetTxHash() => __pbn__TxHash = null;
        private byte[] __pbn__TxHash;

        [ProtoBuf.ProtoMember(2, Name = @"tx_body")]
        public byte[] TxBody
        {
            get { return __pbn__TxBody; }
            set { __pbn__TxBody = value; }
        }
        public bool ShouldSerializeTxBody() => __pbn__TxBody != null;
        public void ResetTxBody() => __pbn__TxBody = null;
        private byte[] __pbn__TxBody;

    }
}