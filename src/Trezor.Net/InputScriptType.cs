using ProtoBuf;

namespace Trezor
{
    public enum InputScriptType
    {
        [ProtoEnum(Name = @"SPENDADDRESS")]
        Spendaddress = 0,
        [ProtoEnum(Name = @"SPENDMULTISIG")]
        Spendmultisig = 1,
        [ProtoEnum(Name = @"EXTERNAL")]
        External = 2,
        [ProtoEnum(Name = @"SPENDWITNESS")]
        Spendwitness = 3,
        [ProtoEnum(Name = @"SPENDP2SHWITNESS")]
        Spendp2shwitness = 4
    }
}