namespace Trezor.Net.Contracts.Stellar
{
    [ProtoBuf.ProtoContract()]
    public class StellarBumpSequenceOp : ProtoBuf.IExtensible
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

        [ProtoBuf.ProtoMember(2, Name = @"bump_to")]
        public ulong BumpTo
        {
            get => __pbn__BumpTo.GetValueOrDefault();
            set => __pbn__BumpTo = value;
        }
        public bool ShouldSerializeBumpTo() => __pbn__BumpTo != null;
        public void ResetBumpTo() => __pbn__BumpTo = null;
        private ulong? __pbn__BumpTo;

    }
}