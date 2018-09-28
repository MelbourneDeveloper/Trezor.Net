using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public enum NEMImportanceTransferMode
    {
        [ProtoEnum(Name = @"ImportanceTransfer_Activate")]
        ImportanceTransferActivate = 1,
        [ProtoEnum(Name = @"ImportanceTransfer_Deactivate")]
        ImportanceTransferDeactivate = 2
    }
}