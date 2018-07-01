using ProtoBuf;

namespace Trezor
{
    public enum NEMSupplyChangeType
    {
        [ProtoEnum(Name = @"SupplyChange_Increase")]
        SupplyChangeIncrease = 1,
        [ProtoEnum(Name = @"SupplyChange_Decrease")]
        SupplyChangeDecrease = 2
    }
}