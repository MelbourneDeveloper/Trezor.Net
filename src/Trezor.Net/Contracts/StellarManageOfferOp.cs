namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarManageOfferOp : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"source_account")]
        [System.ComponentModel.DefaultValue("")]
        public string SourceAccount
        {
            get => __pbn__SourceAccount ?? "";
            set => __pbn__SourceAccount = value;
        }
        public bool ShouldSerializeSourceAccount() => __pbn__SourceAccount != null;
        public void ResetSourceAccount() => __pbn__SourceAccount = null;
        private string __pbn__SourceAccount;

        [ProtoBuf.ProtoMember(2, Name = @"selling_asset")]
        public StellarAssetType SellingAsset { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"buying_asset")]
        public StellarAssetType BuyingAsset { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"amount", DataFormat = ProtoBuf.DataFormat.ZigZag)]
        public long Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private long? __pbn__Amount;

        [ProtoBuf.ProtoMember(5, Name = @"price_n")]
        public uint PriceN
        {
            get => __pbn__PriceN.GetValueOrDefault();
            set => __pbn__PriceN = value;
        }
        public bool ShouldSerializePriceN() => __pbn__PriceN != null;
        public void ResetPriceN() => __pbn__PriceN = null;
        private uint? __pbn__PriceN;

        [ProtoBuf.ProtoMember(6, Name = @"price_d")]
        public uint PriceD
        {
            get => __pbn__PriceD.GetValueOrDefault();
            set => __pbn__PriceD = value;
        }
        public bool ShouldSerializePriceD() => __pbn__PriceD != null;
        public void ResetPriceD() => __pbn__PriceD = null;
        private uint? __pbn__PriceD;

        [ProtoBuf.ProtoMember(7, Name = @"offer_id")]
        public ulong OfferId
        {
            get => __pbn__OfferId.GetValueOrDefault();
            set => __pbn__OfferId = value;
        }
        public bool ShouldSerializeOfferId() => __pbn__OfferId != null;
        public void ResetOfferId() => __pbn__OfferId = null;
        private ulong? __pbn__OfferId;

    }
}