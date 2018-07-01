using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class GetAddress
    {
        #region Fields
        private string __pbn__CoinName;
        private bool? __pbn__ShowDisplay;
        private InputScriptType? __pbn__ScriptType;
        #endregion

        #region Proto Members
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"coin_name")]
        [DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get => __pbn__CoinName ?? @"Bitcoin";
            set => __pbn__CoinName = value;
        }

        [ProtoMember(3, Name = @"show_display")]
        public bool ShowDisplay
        {
            get => __pbn__ShowDisplay.GetValueOrDefault();
            set => __pbn__ShowDisplay = value;
        }

        [ProtoMember(4, Name = @"multisig")]
        public MultisigRedeemScriptType Multisig { get; set; }

        [ProtoMember(5, Name = @"script_type")]
        [DefaultValue(InputScriptType.Spendaddress)]
        public InputScriptType ScriptType
        {
            get => __pbn__ScriptType ?? InputScriptType.Spendaddress;
            set => __pbn__ScriptType = value;
        }
        #endregion

        #region Other Public Properties
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
        public void ResetScriptType() => __pbn__ScriptType = null;
        #endregion

    }
}