namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSetInputAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"vini")]
        public byte[] Vini { get; set; }
        public bool ShouldSerializeVini() => Vini != null;
        public void ResetVini() => Vini = null;

        [ProtoBuf.ProtoMember(2, Name = @"vini_hmac")]
        public byte[] ViniHmac { get; set; }
        public bool ShouldSerializeViniHmac() => ViniHmac != null;
        public void ResetViniHmac() => ViniHmac = null;

        [ProtoBuf.ProtoMember(3, Name = @"pseudo_out")]
        public byte[] PseudoOut { get; set; }
        public bool ShouldSerializePseudoOut() => PseudoOut != null;
        public void ResetPseudoOut() => PseudoOut = null;

        [ProtoBuf.ProtoMember(4, Name = @"pseudo_out_hmac")]
        public byte[] PseudoOutHmac { get; set; }
        public bool ShouldSerializePseudoOutHmac() => PseudoOutHmac != null;
        public void ResetPseudoOutHmac() => PseudoOutHmac = null;

        [ProtoBuf.ProtoMember(5, Name = @"alpha_enc")]
        public byte[] AlphaEnc { get; set; }
        public bool ShouldSerializeAlphaEnc() => AlphaEnc != null;
        public void ResetAlphaEnc() => AlphaEnc = null;

        [ProtoBuf.ProtoMember(6, Name = @"spend_enc")]
        public byte[] SpendEnc { get; set; }
        public bool ShouldSerializeSpendEnc() => SpendEnc != null;
        public void ResetSpendEnc() => SpendEnc = null;
    }
}