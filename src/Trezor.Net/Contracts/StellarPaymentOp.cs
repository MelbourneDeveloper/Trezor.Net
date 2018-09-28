namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarPaymentOp : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"destination_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string DestinationAccount
        {
            get { return __pbn__DestinationAccount ?? ""; }
            set { __pbn__DestinationAccount = value; }
        }
        public bool ShouldSerializeDestinationAccount() => __pbn__DestinationAccount != null;
        public void ResetDestinationAccount() => __pbn__DestinationAccount = null;
        private string __pbn__DestinationAccount;

        [global::ProtoBuf.ProtoMember(3, Name = @"asset")]
        public StellarAssetType Asset { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"amount", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public long Amount
        {
            get { return __pbn__Amount.GetValueOrDefault(); }
            set { __pbn__Amount = value; }
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private long? __pbn__Amount;

    }
}