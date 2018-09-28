namespace Trezor.Net.Contracts.Cardano
{
    [ProtoBuf.ProtoContract()]
    public class CardanoTxAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"transaction")]
        public byte[] Transaction
        {
            get { return __pbn__Transaction; }
            set { __pbn__Transaction = value; }
        }
        public bool ShouldSerializeTransaction() => __pbn__Transaction != null;
        public void ResetTransaction() => __pbn__Transaction = null;
        private byte[] __pbn__Transaction;

    }
}