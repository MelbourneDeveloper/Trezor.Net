namespace Trezor.Net.Contracts.Cardano
{
    [global::ProtoBuf.ProtoContract()]
    public class CardanoTxAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"transaction")]
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