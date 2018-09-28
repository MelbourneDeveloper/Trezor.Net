namespace Trezor.Net.Contracts.Ethereum
{
    [global::ProtoBuf.ProtoContract()]
    public class EthereumTxRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data_length")]
        public uint DataLength
        {
            get { return __pbn__DataLength.GetValueOrDefault(); }
            set { __pbn__DataLength = value; }
        }
        public bool ShouldSerializeDataLength() => __pbn__DataLength != null;
        public void ResetDataLength() => __pbn__DataLength = null;
        private uint? __pbn__DataLength;

        [global::ProtoBuf.ProtoMember(2, Name = @"signature_v")]
        public uint SignatureV
        {
            get { return __pbn__SignatureV.GetValueOrDefault(); }
            set { __pbn__SignatureV = value; }
        }
        public bool ShouldSerializeSignatureV() => __pbn__SignatureV != null;
        public void ResetSignatureV() => __pbn__SignatureV = null;
        private uint? __pbn__SignatureV;

        [global::ProtoBuf.ProtoMember(3, Name = @"signature_r")]
        public byte[] SignatureR
        {
            get { return __pbn__SignatureR; }
            set { __pbn__SignatureR = value; }
        }
        public bool ShouldSerializeSignatureR() => __pbn__SignatureR != null;
        public void ResetSignatureR() => __pbn__SignatureR = null;
        private byte[] __pbn__SignatureR;

        [global::ProtoBuf.ProtoMember(4, Name = @"signature_s")]
        public byte[] SignatureS
        {
            get { return __pbn__SignatureS; }
            set { __pbn__SignatureS = value; }
        }
        public bool ShouldSerializeSignatureS() => __pbn__SignatureS != null;
        public void ResetSignatureS() => __pbn__SignatureS = null;
        private byte[] __pbn__SignatureS;

    }
}