using ProtoBuf;

namespace Trezor
{
    public enum NEMMosaicLevy
    {
        [ProtoEnum(Name = @"MosaicLevy_Absolute")]
        MosaicLevyAbsolute = 1,
        [ProtoEnum(Name = @"MosaicLevy_Percentile")]
        MosaicLevyPercentile = 2
    }
}