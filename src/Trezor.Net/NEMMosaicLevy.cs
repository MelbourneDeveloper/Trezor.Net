using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public enum NEMMosaicLevy
    {
        [ProtoEnum(Name = @"MosaicLevy_Absolute")]
        MosaicLevyAbsolute = 1,
        [ProtoEnum(Name = @"MosaicLevy_Percentile")]
        MosaicLevyPercentile = 2
    }
}