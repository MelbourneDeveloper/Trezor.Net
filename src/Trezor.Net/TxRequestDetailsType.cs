using ProtoBuf;

namespace Trezor
{
    public class TxRequestDetailsType
    {
        [ProtoMember(1, Name = @"request_index")]
        public uint RequestIndex
        {
            get => __pbn__RequestIndex.GetValueOrDefault();
            set => __pbn__RequestIndex = value;
        }
        public bool ShouldSerializeRequestIndex() => __pbn__RequestIndex != null;
        public void ResetRequestIndex() => __pbn__RequestIndex = null;
        private uint? __pbn__RequestIndex;

        [ProtoMember(2, Name = @"tx_hash")]
        public byte[] TxHash { get; set; }

        public bool ShouldSerializeTxHash() => TxHash != null;
        public void ResetTxHash() => TxHash = null;

        [ProtoMember(3, Name = @"extra_data_len")]
        public uint ExtraDataLen
        {
            get => __pbn__ExtraDataLen.GetValueOrDefault();
            set => __pbn__ExtraDataLen = value;
        }
        public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
        public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
        private uint? __pbn__ExtraDataLen;

        [ProtoMember(4, Name = @"extra_data_offset")]
        public uint ExtraDataOffset
        {
            get => __pbn__ExtraDataOffset.GetValueOrDefault();
            set => __pbn__ExtraDataOffset = value;
        }
        public bool ShouldSerializeExtraDataOffset() => __pbn__ExtraDataOffset != null;
        public void ResetExtraDataOffset() => __pbn__ExtraDataOffset = null;
        private uint? __pbn__ExtraDataOffset;

    }
}