using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class SignMessage
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"message", IsRequired = true)]
        public byte[] Message { get; set; }

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

        [ProtoMember(4, Name = @"script_type")]
        [DefaultValue(InputScriptType.Spendaddress)]
        public InputScriptType ScriptType
        {
            get => __pbn__ScriptType ?? InputScriptType.Spendaddress;
            set => __pbn__ScriptType = value;
        }
        public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
        public void ResetScriptType() => __pbn__ScriptType = null;
        private InputScriptType? __pbn__ScriptType;

    }
}