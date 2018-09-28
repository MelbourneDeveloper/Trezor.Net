namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarSetOptionsOp : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"inflation_destination_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string InflationDestinationAccount
        {
            get { return __pbn__InflationDestinationAccount ?? ""; }
            set { __pbn__InflationDestinationAccount = value; }
        }
        public bool ShouldSerializeInflationDestinationAccount() => __pbn__InflationDestinationAccount != null;
        public void ResetInflationDestinationAccount() => __pbn__InflationDestinationAccount = null;
        private string __pbn__InflationDestinationAccount;

        [global::ProtoBuf.ProtoMember(3, Name = @"clear_flags")]
        public uint ClearFlags
        {
            get { return __pbn__ClearFlags.GetValueOrDefault(); }
            set { __pbn__ClearFlags = value; }
        }
        public bool ShouldSerializeClearFlags() => __pbn__ClearFlags != null;
        public void ResetClearFlags() => __pbn__ClearFlags = null;
        private uint? __pbn__ClearFlags;

        [global::ProtoBuf.ProtoMember(4, Name = @"set_flags")]
        public uint SetFlags
        {
            get { return __pbn__SetFlags.GetValueOrDefault(); }
            set { __pbn__SetFlags = value; }
        }
        public bool ShouldSerializeSetFlags() => __pbn__SetFlags != null;
        public void ResetSetFlags() => __pbn__SetFlags = null;
        private uint? __pbn__SetFlags;

        [global::ProtoBuf.ProtoMember(5, Name = @"master_weight")]
        public uint MasterWeight
        {
            get { return __pbn__MasterWeight.GetValueOrDefault(); }
            set { __pbn__MasterWeight = value; }
        }
        public bool ShouldSerializeMasterWeight() => __pbn__MasterWeight != null;
        public void ResetMasterWeight() => __pbn__MasterWeight = null;
        private uint? __pbn__MasterWeight;

        [global::ProtoBuf.ProtoMember(6, Name = @"low_threshold")]
        public uint LowThreshold
        {
            get { return __pbn__LowThreshold.GetValueOrDefault(); }
            set { __pbn__LowThreshold = value; }
        }
        public bool ShouldSerializeLowThreshold() => __pbn__LowThreshold != null;
        public void ResetLowThreshold() => __pbn__LowThreshold = null;
        private uint? __pbn__LowThreshold;

        [global::ProtoBuf.ProtoMember(7, Name = @"medium_threshold")]
        public uint MediumThreshold
        {
            get { return __pbn__MediumThreshold.GetValueOrDefault(); }
            set { __pbn__MediumThreshold = value; }
        }
        public bool ShouldSerializeMediumThreshold() => __pbn__MediumThreshold != null;
        public void ResetMediumThreshold() => __pbn__MediumThreshold = null;
        private uint? __pbn__MediumThreshold;

        [global::ProtoBuf.ProtoMember(8, Name = @"high_threshold")]
        public uint HighThreshold
        {
            get { return __pbn__HighThreshold.GetValueOrDefault(); }
            set { __pbn__HighThreshold = value; }
        }
        public bool ShouldSerializeHighThreshold() => __pbn__HighThreshold != null;
        public void ResetHighThreshold() => __pbn__HighThreshold = null;
        private uint? __pbn__HighThreshold;

        [global::ProtoBuf.ProtoMember(9, Name = @"home_domain")]
        [global::System.ComponentModel.DefaultValue("")]
        public string HomeDomain
        {
            get { return __pbn__HomeDomain ?? ""; }
            set { __pbn__HomeDomain = value; }
        }
        public bool ShouldSerializeHomeDomain() => __pbn__HomeDomain != null;
        public void ResetHomeDomain() => __pbn__HomeDomain = null;
        private string __pbn__HomeDomain;

        [global::ProtoBuf.ProtoMember(10, Name = @"signer_type")]
        public uint SignerType
        {
            get { return __pbn__SignerType.GetValueOrDefault(); }
            set { __pbn__SignerType = value; }
        }
        public bool ShouldSerializeSignerType() => __pbn__SignerType != null;
        public void ResetSignerType() => __pbn__SignerType = null;
        private uint? __pbn__SignerType;

        [global::ProtoBuf.ProtoMember(11, Name = @"signer_key")]
        public byte[] SignerKey
        {
            get { return __pbn__SignerKey; }
            set { __pbn__SignerKey = value; }
        }
        public bool ShouldSerializeSignerKey() => __pbn__SignerKey != null;
        public void ResetSignerKey() => __pbn__SignerKey = null;
        private byte[] __pbn__SignerKey;

        [global::ProtoBuf.ProtoMember(12, Name = @"signer_weight")]
        public uint SignerWeight
        {
            get { return __pbn__SignerWeight.GetValueOrDefault(); }
            set { __pbn__SignerWeight = value; }
        }
        public bool ShouldSerializeSignerWeight() => __pbn__SignerWeight != null;
        public void ResetSignerWeight() => __pbn__SignerWeight = null;
        private uint? __pbn__SignerWeight;

    }
}