using ProtoBuf;

namespace Trezor
{
    public enum RequestType
    {
        [ProtoEnum(Name = @"TXINPUT")]
        Txinput = 0,
        [ProtoEnum(Name = @"TXOUTPUT")]
        Txoutput = 1,
        [ProtoEnum(Name = @"TXMETA")]
        Txmeta = 2,
        [ProtoEnum(Name = @"TXFINISHED")]
        Txfinished = 3,
        [ProtoEnum(Name = @"TXEXTRADATA")]
        Txextradata = 4
    }
}