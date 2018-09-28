using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public enum NEMSupplyChangeType
    {
        [ProtoEnum(Name = @"SupplyChange_Increase")]
        SupplyChangeIncrease = 1,
        [ProtoEnum(Name = @"SupplyChange_Decrease")]
        SupplyChangeDecrease = 2
    }
}