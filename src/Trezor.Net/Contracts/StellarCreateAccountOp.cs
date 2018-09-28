namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarCreateAccountOp : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"new_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NewAccount
        {
            get { return __pbn__NewAccount ?? ""; }
            set { __pbn__NewAccount = value; }
        }
        public bool ShouldSerializeNewAccount() => __pbn__NewAccount != null;
        public void ResetNewAccount() => __pbn__NewAccount = null;
        private string __pbn__NewAccount;

        [global::ProtoBuf.ProtoMember(3, Name = @"starting_balance", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public long StartingBalance
        {
            get { return __pbn__StartingBalance.GetValueOrDefault(); }
            set { __pbn__StartingBalance = value; }
        }
        public bool ShouldSerializeStartingBalance() => __pbn__StartingBalance != null;
        public void ResetStartingBalance() => __pbn__StartingBalance = null;
        private long? __pbn__StartingBalance;

    }
}