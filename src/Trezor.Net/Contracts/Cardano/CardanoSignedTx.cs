namespace Trezor.Net.Contracts.Cardano
{
    [ProtoBuf.ProtoContract()]
    public class CardanoSignedTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tx_hash")]
        public byte[] TxHash { get; set; }
        public bool ShouldSerializeTxHash() => TxHash != null;
        public void ResetTxHash() => TxHash = null;

        [ProtoBuf.ProtoMember(2, Name = @"tx_body")]
        public byte[] TxBody { get; set; }
        public bool ShouldSerializeTxBody() => TxBody != null;
        public void ResetTxBody() => TxBody = null;
    }
}