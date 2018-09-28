namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionInputViniRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"src_entr")]
        public MoneroTransactionSourceEntry SrcEntr { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"vini")]
        public byte[] Vini { get; set; }
        public bool ShouldSerializeVini() => Vini != null;
        public void ResetVini() => Vini = null;

        [ProtoBuf.ProtoMember(3, Name = @"vini_hmac")]
        public byte[] ViniHmac { get; set; }
        public bool ShouldSerializeViniHmac() => ViniHmac != null;
        public void ResetViniHmac() => ViniHmac = null;

        [ProtoBuf.ProtoMember(4, Name = @"pseudo_out")]
        public byte[] PseudoOut { get; set; }
        public bool ShouldSerializePseudoOut() => PseudoOut != null;
        public void ResetPseudoOut() => PseudoOut = null;

        [ProtoBuf.ProtoMember(5, Name = @"pseudo_out_hmac")]
        public byte[] PseudoOutHmac { get; set; }
        public bool ShouldSerializePseudoOutHmac() => PseudoOutHmac != null;
        public void ResetPseudoOutHmac() => PseudoOutHmac = null;
    }
}