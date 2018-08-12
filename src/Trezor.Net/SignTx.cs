using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class SignTx
    {
        [ProtoMember(1, Name = @"outputs_count", IsRequired = true)]
        public uint OutputsCount { get; set; }

        [ProtoMember(2, Name = @"inputs_count", IsRequired = true)]
        public uint InputsCount { get; set; }

        [ProtoMember(3, Name = @"coin_name")]
        [DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get => __pbn__CoinName ?? @"Bitcoin";
            set => __pbn__CoinName = value;
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [ProtoMember(4, Name = @"version")]
        [DefaultValue(1)]
        public uint Version
        {
            get => __pbn__Version ?? 1;
            set => __pbn__Version = value;
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoMember(5, Name = @"lock_time")]
        [DefaultValue(0)]
        public uint LockTime
        {
            get => __pbn__LockTime ?? 0;
            set => __pbn__LockTime = value;
        }
        public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
        public void ResetLockTime() => __pbn__LockTime = null;
        private uint? __pbn__LockTime;

        [ProtoMember(6, Name = @"decred_expiry")]
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