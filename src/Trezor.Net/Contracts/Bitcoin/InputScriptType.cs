namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public enum InputScriptType
    {
        [ProtoBuf.ProtoEnum(Name = @"SPENDADDRESS")]
        Spendaddress = 0,
        [ProtoBuf.ProtoEnum(Name = @"SPENDMULTISIG")]
        Spendmultisig = 1,
        [ProtoBuf.ProtoEnum(Name = @"EXTERNAL")]
        External = 2,
        [ProtoBuf.ProtoEnum(Name = @"SPENDWITNESS")]
        Spendwitness = 3,
        [ProtoBuf.ProtoEnum(Name = @"SPENDP2SHWITNESS")]
        Spendp2shwitness = 4,
    }
}