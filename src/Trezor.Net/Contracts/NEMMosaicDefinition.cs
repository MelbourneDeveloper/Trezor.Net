using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMMosaicDefinition
    {
        [ProtoMember(1, Name = @"name")]
        [DefaultValue("")]
        public string Name
        {
            get => __pbn__Name ?? "";
            set => __pbn__Name = value;
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [ProtoMember(2, Name = @"ticker")]
        [DefaultValue("")]
        public string Ticker
        {
            get => __pbn__Ticker ?? "";
            set => __pbn__Ticker = value;
        }
        public bool ShouldSerializeTicker() => __pbn__Ticker != null;
        public void ResetTicker() => __pbn__Ticker = null;
        private string __pbn__Ticker;

        [ProtoMember(3, Name = @"namespace")]
        [DefaultValue("")]
        public string Namespace
        {
            get => __pbn__Namespace ?? "";
            set => __pbn__Namespace = value;
        }
        public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
        public void ResetNamespace() => __pbn__Namespace = null;
        private string __pbn__Namespace;

        [ProtoMember(4, Name = @"mosaic")]
        [DefaultValue("")]
        public string Mosaic
        {
            get => __pbn__Mosaic ?? "";
            set => __pbn__Mosaic = value;
        }
        public bool ShouldSerializeMosaic() => __pbn__Mosaic != null;
        public void ResetMosaic() => __pbn__Mosaic = null;
        private string __pbn__Mosaic;

        [ProtoMember(5, Name = @"divisibility")]
        public uint Divisibility
        {
            get => __pbn__Divisibility.GetValueOrDefault();
            set => __pbn__Divisibility = value;
        }
        public bool ShouldSerializeDivisibility() => __pbn__Divisibility != null;
        public void ResetDivisibility() => __pbn__Divisibility = null;
        private uint? __pbn__Divisibility;

        [ProtoMember(6, Name = @"levy")]
        [DefaultValue(NEMMosaicLevy.MosaicLevyAbsolute)]
        public NEMMosaicLevy Levy
        {
            get => __pbn__Levy ?? NEMMosaicLevy.MosaicLevyAbsolute;
            set => __pbn__Levy = value;
        }
        public bool ShouldSerializeLevy() => __pbn__Levy != null;
        public void ResetLevy() => __pbn__Levy = null;
        private NEMMosaicLevy? __pbn__Levy;

        [ProtoMember(7, Name = @"fee")]
        public ulong Fee
        {
            get => __pbn__Fee.GetValueOrDefault();
            set => __pbn__Fee = value;
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

        [ProtoMember(8, Name = @"levy_address")]
        [DefaultValue("")]
        public string LevyAddress
        {
            get => __pbn__LevyAddress ?? "";
            set => __pbn__LevyAddress = value;
        }
        public bool ShouldSerializeLevyAddress() => __pbn__LevyAddress != null;
        public void ResetLevyAddress() => __pbn__LevyAddress = null;
        private string __pbn__LevyAddress;

        [ProtoMember(9, Name = @"levy_namespace")]
        [DefaultValue("")]
        public string LevyNamespace
        {
            get => __pbn__LevyNamespace ?? "";
            set => __pbn__LevyNamespace = value;
        }
        public bool ShouldSerializeLevyNamespace() => __pbn__LevyNamespace != null;
        public void ResetLevyNamespace() => __pbn__LevyNamespace = null;
        private string __pbn__LevyNamespace;

        [ProtoMember(10, Name = @"levy_mosaic")]
        [DefaultValue("")]
        public string LevyMosaic
        {
            get => __pbn__LevyMosaic ?? "";
            set => __pbn__LevyMosaic = value;
        }
        public bool ShouldSerializeLevyMosaic() => __pbn__LevyMosaic != null;
        public void ResetLevyMosaic() => __pbn__LevyMosaic = null;
        private string __pbn__LevyMosaic;

        [ProtoMember(11, Name = @"supply")]
        public ulong Supply
        {
            get => __pbn__Supply.GetValueOrDefault();
            set => __pbn__Supply = value;
        }
        public bool ShouldSerializeSupply() => __pbn__Supply != null;
        public void ResetSupply() => __pbn__Supply = null;
        private ulong? __pbn__Supply;

        [ProtoMember(12, Name = @"mutable_supply")]
        public bool MutableSupply
        {
            get => __pbn__MutableSupply.GetValueOrDefault();
            set => __pbn__MutableSupply = value;
        }
        public bool ShouldSerializeMutableSupply() => __pbn__MutableSupply != null;
        public void ResetMutableSupply() => __pbn__MutableSupply = null;
        private bool? __pbn__MutableSupply;

        [ProtoMember(13, Name = @"transferable")]
        public bool Transferable
        {
            get => __pbn__Transferable.GetValueOrDefault();
            set => __pbn__Transferable = value;
        }
        public bool ShouldSerializeTransferable() => __pbn__Transferable != null;
        public void ResetTransferable() => __pbn__Transferable = null;
        private bool? __pbn__Transferable;

        [ProtoMember(14, Name = @"description")]
        [DefaultValue("")]
        public string Description
        {
            get => __pbn__Description ?? "";
            set => __pbn__Description = value;
        }
        public bool ShouldSerializeDescription() => __pbn__Description != null;
        public void ResetDescription() => __pbn__Description = null;
        private string __pbn__Description;

        [ProtoMember(15, Name = @"networks")]
        public uint[] Networks { get; set; }

    }
}