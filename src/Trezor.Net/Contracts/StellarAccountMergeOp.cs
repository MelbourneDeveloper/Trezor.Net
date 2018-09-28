namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarAccountMergeOp : global::ProtoBuf.IExtensible
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

    }
}