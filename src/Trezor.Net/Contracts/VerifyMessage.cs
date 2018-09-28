using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class VerifyMessage
    {
        [ProtoMember(1, Name = @"address")]
        [DefaultValue("")]
        public string Address
        {
            get => __pbn__Address ?? "";
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;

        [ProtoMember(3, Name = @"message")]
        public byte[] Message { get; set; }

        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;

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

    }
}