using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class NEMMosaicSupplyChange
    {
        [ProtoMember(1, Name = @"namespace")]
        [DefaultValue("")]
        public string Namespace
        {
            get => __pbn__Namespace ?? "";
            set => __pbn__Namespace = value;
        }
        public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
        public void ResetNamespace() => __pbn__Namespace = null;
        private string __pbn__Namespace;

        [ProtoMember(2, Name = @"mosaic")]
        [DefaultValue("")]
        public string Mosaic
        {
            get => __pbn__Mosaic ?? "";
            set => __pbn__Mosaic = value;
        }
        public bool ShouldSerializeMosaic() => __pbn__Mosaic != null;
        public void ResetMosaic() => __pbn__Mosaic = null;
        private string __pbn__Mosaic;

        [ProtoMember(3, Name = @"type")]
        [DefaultValue(NEMSupplyChangeType.SupplyChangeIncrease)]
        public NEMSupplyChangeType Type
        {
            get => __pbn__Type ?? NEMSupplyChangeType.SupplyChangeIncrease;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private NEMSupplyChangeType? __pbn__Type;

        [ProtoMember(4, Name = @"delta")]
        public ulong Delta
        {
            get => __pbn__Delta.GetValueOrDefault();
            set => __pbn__Delta = value;
        }
        public bool ShouldSerializeDelta() => __pbn__Delta != null;
        public void ResetDelta() => __pbn__Delta = null;
        private ulong? __pbn__Delta;

    }
}