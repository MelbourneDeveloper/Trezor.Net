namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarSetOptionsOp : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"inflation_destination_account")]
        [System.ComponentModel.DefaultValue("")]
        public string InflationDestinationAccount
        {
            get => __pbn__InflationDestinationAccount ?? "";
            set => __pbn__InflationDestinationAccount = value;
        }
        public bool ShouldSerializeInflationDestinationAccount() => __pbn__InflationDestinationAccount != null;
        public void ResetInflationDestinationAccount() => __pbn__InflationDestinationAccount = null;
        private string __pbn__InflationDestinationAccount;

        [ProtoBuf.ProtoMember(3, Name = @"clear_flags")]
        public uint ClearFlags
        {
            get => __pbn__ClearFlags.GetValueOrDefault();
            set => __pbn__ClearFlags = value;
        }
        public bool ShouldSerializeClearFlags() => __pbn__ClearFlags != null;
        public void ResetClearFlags() => __pbn__ClearFlags = null;
        private uint? __pbn__ClearFlags;

        [ProtoBuf.ProtoMember(4, Name = @"set_flags")]
        public uint SetFlags
        {
            get => __pbn__SetFlags.GetValueOrDefault();
            set => __pbn__SetFlags = value;
        }
        public bool ShouldSerializeSetFlags() => __pbn__SetFlags != null;
        public void ResetSetFlags() => __pbn__SetFlags = null;
        private uint? __pbn__SetFlags;

        [ProtoBuf.ProtoMember(5, Name = @"master_weight")]
        public uint MasterWeight
        {
            get => __pbn__MasterWeight.GetValueOrDefault();
            set => __pbn__MasterWeight = value;
        }
        public bool ShouldSerializeMasterWeight() => __pbn__MasterWeight != null;
        public void ResetMasterWeight() => __pbn__MasterWeight = null;
        private uint? __pbn__MasterWeight;

        [ProtoBuf.ProtoMember(6, Name = @"low_threshold")]
        public uint LowThreshold
        {
            get => __pbn__LowThreshold.GetValueOrDefault();
            set => __pbn__LowThreshold = value;
        }
        public bool ShouldSerializeLowThreshold() => __pbn__LowThreshold != null;
        public void ResetLowThreshold() => __pbn__LowThreshold = null;
        private uint? __pbn__LowThreshold;

        [ProtoBuf.ProtoMember(7, Name = @"medium_threshold")]
        public uint MediumThreshold
        {
            get => __pbn__MediumThreshold.GetValueOrDefault();
            set => __pbn__MediumThreshold = value;
        }
        public bool ShouldSerializeMediumThreshold() => __pbn__MediumThreshold != null;
        public void ResetMediumThreshold() => __pbn__MediumThreshold = null;
        private uint? __pbn__MediumThreshold;

        [ProtoBuf.ProtoMember(8, Name = @"high_threshold")]
        public uint HighThreshold
        {
            get => __pbn__HighThreshold.GetValueOrDefault();
            set => __pbn__HighThreshold = value;
        }
        public bool ShouldSerializeHighThreshold() => __pbn__HighThreshold != null;
        public void ResetHighThreshold() => __pbn__HighThreshold = null;
        private uint? __pbn__HighThreshold;

        [ProtoBuf.ProtoMember(9, Name = @"home_domain")]
        [System.ComponentModel.DefaultValue("")]
        public string HomeDomain
        {
            get => __pbn__HomeDomain ?? "";
            set => __pbn__HomeDomain = value;
        }
        public bool ShouldSerializeHomeDomain() => __pbn__HomeDomain != null;
        public void ResetHomeDomain() => __pbn__HomeDomain = null;
        private string __pbn__HomeDomain;

        [ProtoBuf.ProtoMember(10, Name = @"signer_type")]
        public uint SignerType
        {
            get => __pbn__SignerType.GetValueOrDefault();
            set => __pbn__SignerType = value;
        }
        public bool ShouldSerializeSignerType() => __pbn__SignerType != null;
        public void ResetSignerType() => __pbn__SignerType = null;
        private uint? __pbn__SignerType;

        [ProtoBuf.ProtoMember(11, Name = @"signer_key")]
        public byte[] SignerKey { get; set; }
        public bool ShouldSerializeSignerKey() => SignerKey != null;
        public void ResetSignerKey() => SignerKey = null;

        [ProtoBuf.ProtoMember(12, Name = @"signer_weight")]
        public uint SignerWeight
        {
            get => __pbn__SignerWeight.GetValueOrDefault();
            set => __pbn__SignerWeight = value;
        }
        public bool ShouldSerializeSignerWeight() => __pbn__SignerWeight != null;
        public void ResetSignerWeight() => __pbn__SignerWeight = null;
        private uint? __pbn__SignerWeight;

    }
}