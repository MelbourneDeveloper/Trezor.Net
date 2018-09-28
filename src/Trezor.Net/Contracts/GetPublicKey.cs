namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public class GetPublicKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ecdsa_curve_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EcdsaCurveName
        {
            get { return __pbn__EcdsaCurveName ?? ""; }
            set { __pbn__EcdsaCurveName = value; }
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

        [global::ProtoBuf.ProtoMember(3, Name = @"show_display")]
        public bool ShowDisplay
        {
            get { return __pbn__ShowDisplay.GetValueOrDefault(); }
            set { __pbn__ShowDisplay = value; }
        }
        public bool ShouldSerializeShowDisplay() => __pbn__ShowDisplay != null;
        public void ResetShowDisplay() => __pbn__ShowDisplay = null;
        private bool? __pbn__ShowDisplay;

        [global::ProtoBuf.ProtoMember(4, Name = @"coin_name")]
        [global::System.ComponentModel.DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get { return __pbn__CoinName ?? @"Bitcoin"; }
            set { __pbn__CoinName = value; }
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [global::ProtoBuf.ProtoMember(5, Name = @"script_type")]
        [global::System.ComponentModel.DefaultValue(InputScriptType.Spendaddress)]
        public InputScriptType ScriptType
        {
            get { return __pbn__ScriptType ?? InputScriptType.Spendaddress; }
            set { __pbn__ScriptType = value; }
        }
        public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
        public void ResetScriptType() => __pbn__ScriptType = null;
        private InputScriptType? __pbn__ScriptType;

    }
}