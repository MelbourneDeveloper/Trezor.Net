using System.Collections.Generic;
using ProtoBuf;

namespace Trezor
{
    public class TransactionType
    {
        [ProtoMember(1, Name = @"version")]
        public uint Version
        {
            get => __pbn__Version.GetValueOrDefault();
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoMember(2, Name = @"inputs")]
        public List<TxInputType> Inputs { get; } = new List<TxInputType>();

        [ProtoMember(3, Name = @"bin_outputs")]
        public List<TxOutputBinType> BinOutputs { get; } = new List<TxOutputBinType>();

        [ProtoMember(5, Name = @"outputs")]
        public List<TxOutputType> Outputs { get; } = new List<TxOutputType>();

        [ProtoMember(4, Name = @"lock_time")]
        public uint LockTime
        {
            get => __pbn__LockTime.GetValueOrDefault();
            set => __pbn__LockTime = value;
        }
        public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
        public void ResetLockTime() => __pbn__LockTime = null;
        private uint? __pbn__LockTime;

        [ProtoMember(6, Name = @"inputs_cnt")]
        public uint InputsCnt
        {
            get => __pbn__InputsCnt.GetValueOrDefault();
            set => __pbn__InputsCnt = value;
        }
        public bool ShouldSerializeInputsCnt() => __pbn__InputsCnt != null;
        public void ResetInputsCnt() => __pbn__InputsCnt = null;
        private uint? __pbn__InputsCnt;

        [ProtoMember(7, Name = @"outputs_cnt")]
        public uint OutputsCnt
        {
            get => __pbn__OutputsCnt.GetValueOrDefault();
            set => __pbn__OutputsCnt = value;
        }
        public bool ShouldSerializeOutputsCnt() => __pbn__OutputsCnt != null;
        public void ResetOutputsCnt() => __pbn__OutputsCnt = null;
        private uint? __pbn__OutputsCnt;

        [ProtoMember(8, Name = @"extra_data")]
        public byte[] ExtraData { get; set; }

        public bool ShouldSerializeExtraData() => ExtraData != null;
        public void ResetExtraData() => ExtraData = null;

        [ProtoMember(9, Name = @"extra_data_len")]
        public uint ExtraDataLen
        {
            get => __pbn__ExtraDataLen.GetValueOrDefault();
            set => __pbn__ExtraDataLen = value;
        }
        public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
        public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
        private uint? __pbn__ExtraDataLen;

        [ProtoMember(10, Name = @"decred_expiry")]
        public uint DecredExpiry
        {
            get => __pbn__DecredExpiry.GetValueOrDefault();
            set => __pbn__DecredExpiry = value;
        }
        public bool ShouldSerializeDecredExpiry() => __pbn__DecredExpiry != null;
        public void ResetDecredExpiry() => __pbn__DecredExpiry = null;
        private uint? __pbn__DecredExpiry;

    }
}