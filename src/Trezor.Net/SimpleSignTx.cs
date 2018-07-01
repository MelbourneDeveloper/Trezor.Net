using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class SimpleSignTx
    {
        [ProtoMember(1, Name = @"inputs")]
        public List<TxInputType> Inputs { get; } = new List<TxInputType>();

        [ProtoMember(2, Name = @"outputs")]
        public List<TxOutputType> Outputs { get; } = new List<TxOutputType>();

        [ProtoMember(3, Name = @"transactions")]
        public List<TransactionType> Transactions { get; } = new List<TransactionType>();

        [ProtoMember(4, Name = @"coin_name")]
        [DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get => __pbn__CoinName ?? @"Bitcoin";
            set => __pbn__CoinName = value;
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [ProtoMember(5, Name = @"version")]
        [DefaultValue(1)]
        public uint Version
        {
            get => __pbn__Version ?? 1;
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoMember(6, Name = @"lock_time")]
        [DefaultValue(0)]
        public uint LockTime
        {
            get => __pbn__LockTime ?? 0;
            set => __pbn__LockTime = value;
        }
        public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
        public void ResetLockTime() => __pbn__LockTime = null;
        private uint? __pbn__LockTime;

    }
}