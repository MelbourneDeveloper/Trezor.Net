using ProtoBuf;

namespace Trezor
{
    public class TxRequestSerializedType
    {
        [ProtoMember(1, Name = @"signature_index")]
        public uint SignatureIndex
        {
            get => __pbn__SignatureIndex.GetValueOrDefault();
            set => __pbn__SignatureIndex = value;
        }
        public bool ShouldSerializeSignatureIndex() => __pbn__SignatureIndex != null;
        public void ResetSignatureIndex() => __pbn__SignatureIndex = null;
        private uint? __pbn__SignatureIndex;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;

        [ProtoMember(3, Name = @"serialized_tx")]
        public byte[] SerializedTx { get; set; }

        public bool ShouldSerializeSerializedTx() => SerializedTx != null;
        public void ResetSerializedTx() => SerializedTx = null;
    }
}