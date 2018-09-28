namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarPathPaymentOp : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"send_asset")]
        public StellarAssetType SendAsset { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"send_max", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public long SendMax
        {
            get { return __pbn__SendMax.GetValueOrDefault(); }
            set { __pbn__SendMax = value; }
        }
        public bool ShouldSerializeSendMax() => __pbn__SendMax != null;
        public void ResetSendMax() => __pbn__SendMax = null;
        private long? __pbn__SendMax;

        [global::ProtoBuf.ProtoMember(4, Name = @"destination_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DestinationAccount
        {
            get { return __pbn__DestinationAccount ?? ""; }
            set { __pbn__DestinationAccount = value; }
        }
        public bool ShouldSerializeDestinationAccount() => __pbn__DestinationAccount != null;
        public void ResetDestinationAccount() => __pbn__DestinationAccount = null;
        private string __pbn__DestinationAccount;

        [global::ProtoBuf.ProtoMember(5, Name = @"destination_asset")]
        public StellarAssetType DestinationAsset { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"destination_amount", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public long DestinationAmount
        {
            get { return __pbn__DestinationAmount.GetValueOrDefault(); }
            set { __pbn__DestinationAmount = value; }
        }
        public bool ShouldSerializeDestinationAmount() => __pbn__DestinationAmount != null;
        public void ResetDestinationAmount() => __pbn__DestinationAmount = null;
        private long? __pbn__DestinationAmount;

        [global::ProtoBuf.ProtoMember(7, Name = @"paths")]
        public global::System.Collections.Generic.List<StellarAssetType> Paths { get; } = new global::System.Collections.Generic.List<StellarAssetType>();

    }
}