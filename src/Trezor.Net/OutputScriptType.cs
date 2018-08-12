using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public enum OutputScriptType
    {
        [ProtoEnum(Name = @"PAYTOADDRESS")]
        Paytoaddress = 0,
        [ProtoEnum(Name = @"PAYTOSCRIPTHASH")]
        Paytoscripthash = 1,
        [ProtoEnum(Name = @"PAYTOMULTISIG")]
        Paytomultisig = 2,
        [ProtoEnum(Name = @"PAYTOOPRETURN")]
        Paytoopreturn = 3,
        [ProtoEnum(Name = @"PAYTOWITNESS")]
        Paytowitness = 4,
        [ProtoEnum(Name = @"PAYTOP2SHWITNESS")]
        Paytop2shwitness = 5
    }
}