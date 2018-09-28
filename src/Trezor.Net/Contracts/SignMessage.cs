namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public class SignMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"message", IsRequired = true)]
        public byte[] Message { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"coin_name")]
        [global::System.ComponentModel.DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get { return __pbn__CoinName ?? @"Bitcoin"; }
            set { __pbn__CoinName = value; }
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [global::ProtoBuf.ProtoMember(4, Name = @"script_type")]
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