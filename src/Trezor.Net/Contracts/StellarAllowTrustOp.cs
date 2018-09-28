namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarAllowTrustOp : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"trusted_account")]
        [System.ComponentModel.DefaultValue("")]
        public string TrustedAccount
        {
            get { return __pbn__TrustedAccount ?? ""; }
            set { __pbn__TrustedAccount = value; }
        }
        public bool ShouldSerializeTrustedAccount() => __pbn__TrustedAccount != null;
        public void ResetTrustedAccount() => __pbn__TrustedAccount = null;
        private string __pbn__TrustedAccount;

        [ProtoBuf.ProtoMember(3, Name = @"asset_type")]
        public uint AssetType
        {
            get { return __pbn__AssetType.GetValueOrDefault(); }
            set { __pbn__AssetType = value; }
        }
        public bool ShouldSerializeAssetType() => __pbn__AssetType != null;
        public void ResetAssetType() => __pbn__AssetType = null;
        private uint? __pbn__AssetType;

        [ProtoBuf.ProtoMember(4, Name = @"asset_code")]
        [System.ComponentModel.DefaultValue("")]
        public string AssetCode
        {
            get { return __pbn__AssetCode ?? ""; }
            set { __pbn__AssetCode = value; }
        }
        public bool ShouldSerializeAssetCode() => __pbn__AssetCode != null;
        public void ResetAssetCode() => __pbn__AssetCode = null;
        private string __pbn__AssetCode;

        [ProtoBuf.ProtoMember(5, Name = @"is_authorized")]
        public uint IsAuthorized
        {
            get { return __pbn__IsAuthorized.GetValueOrDefault(); }
            set { __pbn__IsAuthorized = value; }
        }
        public bool ShouldSerializeIsAuthorized() => __pbn__IsAuthorized != null;
        public void ResetIsAuthorized() => __pbn__IsAuthorized = null;
        private uint? __pbn__IsAuthorized;

    }
}