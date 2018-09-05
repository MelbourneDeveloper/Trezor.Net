using ProtoBuf;

namespace Trezor.Net.Contracts
{
    public enum RecoveryDeviceType
    {
        [ProtoEnum(Name = @"RecoveryDeviceType_ScrambledWords")]
        RecoveryDeviceTypeScrambledWords = 0,
        [ProtoEnum(Name = @"RecoveryDeviceType_Matrix")]
        RecoveryDeviceTypeMatrix = 1
    }
}