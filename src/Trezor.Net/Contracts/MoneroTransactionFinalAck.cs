namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionFinalAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"cout_key")]
        public byte[] CoutKey
        {
            get { return __pbn__CoutKey; }
            set { __pbn__CoutKey = value; }
        }
        public bool ShouldSerializeCoutKey() => __pbn__CoutKey != null;
        public void ResetCoutKey() => __pbn__CoutKey = null;
        private byte[] __pbn__CoutKey;

        [ProtoBuf.ProtoMember(2, Name = @"salt")]
        public byte[] Salt
        {
            get { return __pbn__Salt; }
            set { __pbn__Salt = value; }
        }
        public bool ShouldSerializeSalt() => __pbn__Salt != null;
        public void ResetSalt() => __pbn__Salt = null;
        private byte[] __pbn__Salt;

        [ProtoBuf.ProtoMember(3, Name = @"rand_mult")]
        public byte[] RandMult
        {
            get { return __pbn__RandMult; }
            set { __pbn__RandMult = value; }
        }
        public bool ShouldSerializeRandMult() => __pbn__RandMult != null;
        public void ResetRandMult() => __pbn__RandMult = null;
        private byte[] __pbn__RandMult;

        [ProtoBuf.ProtoMember(4, Name = @"tx_enc_keys")]
        public byte[] TxEncKeys
        {
            get { return __pbn__TxEncKeys; }
            set { __pbn__TxEncKeys = value; }
        }
        public bool ShouldSerializeTxEncKeys() => __pbn__TxEncKeys != null;
        public void ResetTxEncKeys() => __pbn__TxEncKeys = null;
        private byte[] __pbn__TxEncKeys;

    }
}