using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMMosaic
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

        [ProtoMember(3, Name = @"quantity")]
        public ulong Quantity
        {
            get => __pbn__Quantity.GetValueOrDefault();
            set => __pbn__Quantity = value;
        }
        public bool ShouldSerializeQuantity() => __pbn__Quantity != null;
        public void ResetQuantity() => __pbn__Quantity = null;
        private ulong? __pbn__Quantity;

    }
}