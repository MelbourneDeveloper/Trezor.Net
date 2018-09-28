namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionFinalAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"cout_key")]
        public byte[] CoutKey { get; set; }
        public bool ShouldSerializeCoutKey() => CoutKey != null;
        public void ResetCoutKey() => CoutKey = null;

        [ProtoBuf.ProtoMember(2, Name = @"salt")]
        public byte[] Salt { get; set; }
        public bool ShouldSerializeSalt() => Salt != null;
        public void ResetSalt() => Salt = null;

        [ProtoBuf.ProtoMember(3, Name = @"rand_mult")]
        public byte[] RandMult { get; set; }
        public bool ShouldSerializeRandMult() => RandMult != null;
        public void ResetRandMult() => RandMult = null;

        [ProtoBuf.ProtoMember(4, Name = @"tx_enc_keys")]
        public byte[] TxEncKeys { get; set; }
        public bool ShouldSerializeTxEncKeys() => TxEncKeys != null;
        public void ResetTxEncKeys() => TxEncKeys = null;
    }
}