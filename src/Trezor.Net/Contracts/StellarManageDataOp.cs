namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarManageDataOp : global::ProtoBuf.IExtensible
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

        [global::ProtoBuf.ProtoMember(2, Name = @"key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Key
        {
            get { return __pbn__Key ?? ""; }
            set { __pbn__Key = value; }
        }
        public bool ShouldSerializeKey() => __pbn__Key != null;
        public void ResetKey() => __pbn__Key = null;
        private string __pbn__Key;

        [global::ProtoBuf.ProtoMember(3, Name = @"value")]
        public byte[] Value
        {
            get { return __pbn__Value; }
            set { __pbn__Value = value; }
        }
        public bool ShouldSerializeValue() => __pbn__Value != null;
        public void ResetValue() => __pbn__Value = null;
        private byte[] __pbn__Value;

    }
}