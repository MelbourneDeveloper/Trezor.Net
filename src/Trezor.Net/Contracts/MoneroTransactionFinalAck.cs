namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionFinalAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"cout_key")]
        public byte[] CoutKey
        {
            get { return __pbn__CoutKey; }
            set { __pbn__CoutKey = value; }
        }
        public bool ShouldSerializeCoutKey() => __pbn__CoutKey != null;
        public void ResetCoutKey() => __pbn__CoutKey = null;
        private byte[] __pbn__CoutKey;

        [global::ProtoBuf.ProtoMember(2, Name = @"salt")]
        public byte[] Salt
        {
            get { return __pbn__Salt; }
            set { __pbn__Salt = value; }
        }
        public bool ShouldSerializeSalt() => __pbn__Salt != null;
        public void ResetSalt() => __pbn__Salt = null;
        private byte[] __pbn__Salt;

        [global::ProtoBuf.ProtoMember(3, Name = @"rand_mult")]
        public byte[] RandMult
        {
            get { return __pbn__RandMult; }
            set { __pbn__RandMult = value; }
        }
        public bool ShouldSerializeRandMult() => __pbn__RandMult != null;
        public void ResetRandMult() => __pbn__RandMult = null;
        private byte[] __pbn__RandMult;

        [global::ProtoBuf.ProtoMember(4, Name = @"tx_enc_keys")]
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