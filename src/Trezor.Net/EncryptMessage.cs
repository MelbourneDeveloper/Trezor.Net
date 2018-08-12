using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EncryptMessage
    {
        [ProtoMember(1, Name = @"pubkey")]
        public byte[] Pubkey { get; set; }

        public bool ShouldSerializePubkey() => Pubkey != null;
        public void ResetPubkey() => Pubkey = null;

        [ProtoMember(2, Name = @"message")]
        public byte[] Message { get; set; }

        public bool ShouldSerializeMessage() => Message != null;
        public void ResetMessage() => Message = null;

        [ProtoMember(3, Name = @"display_only")]
        public bool DisplayOnly
        {
            get => __pbn__DisplayOnly.GetValueOrDefault();
            set => __pbn__DisplayOnly = value;
        }
        public bool ShouldSerializeDisplayOnly() => __pbn__DisplayOnly != null;
        public void ResetDisplayOnly() => __pbn__DisplayOnly = null;
        private bool? __pbn__DisplayOnly;

        [ProtoMember(4, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(5, Name = @"coin_name")]
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