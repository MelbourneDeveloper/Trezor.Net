namespace Trezor.Net.Contracts.Cardano
{
    [global::ProtoBuf.ProtoContract()]
    public class CardanoSignedTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx_hash")]
        public byte[] TxHash
        {
            get { return __pbn__TxHash; }
            set { __pbn__TxHash = value; }
        }
        public bool ShouldSerializeTxHash() => __pbn__TxHash != null;
        public void ResetTxHash() => __pbn__TxHash = null;
        private byte[] __pbn__TxHash;

        [global::ProtoBuf.ProtoMember(2, Name = @"tx_body")]
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