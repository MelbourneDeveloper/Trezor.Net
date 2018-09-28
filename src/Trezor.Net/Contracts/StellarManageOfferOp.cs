namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarManageOfferOp : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"source_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceAccount
        {
            get { return __pbn__SourceAccount ?? ""; }
            set { __pbn__SourceAccount = value; }
        }
        public bool ShouldSerializeSourceAccount() => __pbn__SourceAccount != null;
        public void ResetSourceAccount() => __pbn__SourceAccount = null;
        private string __pbn__SourceAccount;

        [global::ProtoBuf.ProtoMember(2, Name = @"selling_asset")]
        public StellarAssetType SellingAsset { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"buying_asset")]
        public StellarAssetType BuyingAsset { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"amount", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public long Amount
        {
            get { return __pbn__Amount.GetValueOrDefault(); }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private long? __pbn__Amount;

        [global::ProtoBuf.ProtoMember(5, Name = @"price_n")]
        public uint PriceN
        {
            get { return __pbn__PriceN.GetValueOrDefault(); }
            set { __pbn__PriceN = value; }
        }
        public bool ShouldSerializePriceN() => __pbn__PriceN != null;
        public void ResetPriceN() => __pbn__PriceN = null;
        private uint? __pbn__PriceN;

        [global::ProtoBuf.ProtoMember(6, Name = @"price_d")]
        public uint PriceD
        {
            get { return __pbn__PriceD.GetValueOrDefault(); }
            set { __pbn__PriceD = value; }
        }
        public bool ShouldSerializePriceD() => __pbn__PriceD != null;
        public void ResetPriceD() => __pbn__PriceD = null;
        private uint? __pbn__PriceD;

        [global::ProtoBuf.ProtoMember(7, Name = @"offer_id")]
        public ulong OfferId
        {
            get { return __pbn__OfferId.GetValueOrDefault(); }
            set { __pbn__OfferId = value; }
        }
        public bool ShouldSerializeOfferId() => __pbn__OfferId != null;
        public void ResetOfferId() => __pbn__OfferId = null;
        private ulong? __pbn__OfferId;

    }
}