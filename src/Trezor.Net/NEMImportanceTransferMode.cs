using ProtoBuf;

namespace Trezor
{
    public enum NEMImportanceTransferMode
    {
        [ProtoEnum(Name = @"ImportanceTransfer_Activate")]
        ImportanceTransferActivate = 1,
        [ProtoEnum(Name = @"ImportanceTransfer_Deactivate")]
        ImportanceTransferDeactivate = 2
    }
}