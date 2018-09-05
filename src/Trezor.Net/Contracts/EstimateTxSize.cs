using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class EstimateTxSize
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

    }
}