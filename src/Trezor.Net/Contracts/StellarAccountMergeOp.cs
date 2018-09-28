namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarAccountMergeOp : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"destination_account")]
        [System.ComponentModel.DefaultValue("")]
        public string DestinationAccount
        {
            get => __pbn__DestinationAccount ?? "";
            set => __pbn__DestinationAccount = value;
        }
        public bool ShouldSerializeDestinationAccount() => __pbn__DestinationAccount != null;
        public void ResetDestinationAccount() => __pbn__DestinationAccount = null;
        private string __pbn__DestinationAccount;

    }
}