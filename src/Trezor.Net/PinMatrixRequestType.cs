using ProtoBuf;

namespace Trezor
{
    public enum PinMatrixRequestType
    {
        [ProtoEnum(Name = @"PinMatrixRequestType_Current")]
        PinMatrixRequestTypeCurrent = 1,
        [ProtoEnum(Name = @"PinMatrixRequestType_NewFirst")]
        PinMatrixRequestTypeNewFirst = 2,
        [ProtoEnum(Name = @"PinMatrixRequestType_NewSecond")]
        PinMatrixRequestTypeNewSecond = 3
    }
}