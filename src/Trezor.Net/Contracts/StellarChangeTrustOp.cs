namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarChangeTrustOp : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"source_account")]
        [System.ComponentModel.DefaultValue("")]
        public string SourceAccount
        {
            get { return __pbn__SourceAccount ?? ""; }
            set { __pbn__SourceAccount = value; }
        }
        public bool ShouldSerializeSourceAccount() => __pbn__SourceAccount != null;
        public void ResetSourceAccount() => __pbn__SourceAccount = null;
        private string __pbn__SourceAccount;

        [ProtoBuf.ProtoMember(2, Name = @"asset")]
        public StellarAssetType Asset { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"limit")]
        public ulong Limit
        {
            get { return __pbn__Limit.GetValueOrDefault(); }
            set { __pbn__Limit = value; }
        }
        public bool ShouldSerializeLimit() => __pbn__Limit != null;
        public void ResetLimit() => __pbn__Limit = null;
        private ulong? __pbn__Limit;

    }
}