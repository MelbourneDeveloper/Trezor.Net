namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionInputViniRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"src_entr")]
        public MoneroTransactionSourceEntry SrcEntr { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"vini")]
        public byte[] Vini
        {
            get { return __pbn__Vini; }
            set { __pbn__Vini = value; }
        }
        public bool ShouldSerializeVini() => __pbn__Vini != null;
        public void ResetVini() => __pbn__Vini = null;
        private byte[] __pbn__Vini;

        [global::ProtoBuf.ProtoMember(3, Name = @"vini_hmac")]
        public byte[] ViniHmac
        {
            get { return __pbn__ViniHmac; }
            set { __pbn__ViniHmac = value; }
        }
        public bool ShouldSerializeViniHmac() => __pbn__ViniHmac != null;
        public void ResetViniHmac() => __pbn__ViniHmac = null;
        private byte[] __pbn__ViniHmac;

        [global::ProtoBuf.ProtoMember(4, Name = @"pseudo_out")]
        public byte[] PseudoOut
        {
            get { return __pbn__PseudoOut; }
            set { __pbn__PseudoOut = value; }
        }
        public bool ShouldSerializePseudoOut() => __pbn__PseudoOut != null;
        public void ResetPseudoOut() => __pbn__PseudoOut = null;
        private byte[] __pbn__PseudoOut;

        [global::ProtoBuf.ProtoMember(5, Name = @"pseudo_out_hmac")]
        public byte[] PseudoOutHmac
        {
            get { return __pbn__PseudoOutHmac; }
            set { __pbn__PseudoOutHmac = value; }
        }
        public bool ShouldSerializePseudoOutHmac() => __pbn__PseudoOutHmac != null;
        public void ResetPseudoOutHmac() => __pbn__PseudoOutHmac = null;
        private byte[] __pbn__PseudoOutHmac;

    }
}