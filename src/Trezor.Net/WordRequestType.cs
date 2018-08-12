using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public enum WordRequestType
    {
        [ProtoEnum(Name = @"WordRequestType_Plain")]
        WordRequestTypePlain = 0,
        [ProtoEnum(Name = @"WordRequestType_Matrix9")]
        WordRequestTypeMatrix9 = 1,
        [ProtoEnum(Name = @"WordRequestType_Matrix6")]
        WordRequestTypeMatrix6 = 2
    }
}