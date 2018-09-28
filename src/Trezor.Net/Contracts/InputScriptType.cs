namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public enum InputScriptType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDADDRESS")]
        Spendaddress = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDMULTISIG")]
        Spendmultisig = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"EXTERNAL")]
        External = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDWITNESS")]
        Spendwitness = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"SPENDP2SHWITNESS")]
        Spendp2shwitness = 4,
    }
}