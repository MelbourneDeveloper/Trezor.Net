using ProtoBuf;

namespace Trezor
{
    public class EthereumTxRequest
    {
        [ProtoMember(1, Name = @"data_length")]
        public uint DataLength
        {
            get => __pbn__DataLength.GetValueOrDefault();
            set => __pbn__DataLength = value;
        }
        public bool ShouldSerializeDataLength() => __pbn__DataLength != null;
        public void ResetDataLength() => __pbn__DataLength = null;
        private uint? __pbn__DataLength;

        [ProtoMember(2, Name = @"signature_v")]
        public uint SignatureV
        {
            get => __pbn__SignatureV.GetValueOrDefault();
            set => __pbn__SignatureV = value;
        }
        public bool ShouldSerializeSignatureV() => __pbn__SignatureV != null;
        public void ResetSignatureV() => __pbn__SignatureV = null;
        private uint? __pbn__SignatureV;

        [ProtoMember(3, Name = @"signature_r")]
        public byte[] SignatureR { get; set; }

        public bool ShouldSerializeSignatureR() => SignatureR != null;
        public void ResetSignatureR() => SignatureR = null;

        [ProtoMember(4, Name = @"signature_s")]
        public byte[] SignatureS { get; set; }

        public bool ShouldSerializeSignatureS() => SignatureS != null;
        public void ResetSignatureS() => SignatureS = null;
    }
}