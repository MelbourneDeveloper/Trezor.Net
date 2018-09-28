namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public class SignMessage : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"message", IsRequired = true)]
        public byte[] Message { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"coin_name")]
        [System.ComponentModel.DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get => __pbn__CoinName ?? @"Bitcoin";
            set => __pbn__CoinName = value;
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [ProtoBuf.ProtoMember(4, Name = @"script_type")]
        [System.ComponentModel.DefaultValue(InputScriptType.Spendaddress)]
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