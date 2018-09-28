namespace Trezor.Net.Contracts.Tezos
{
    [ProtoBuf.ProtoContract()]
    public class TezosSignedTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"signature")]
        [System.ComponentModel.DefaultValue("")]
        public string Signature
        {
            get { return __pbn__Signature ?? ""; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private string __pbn__Signature;

        [ProtoBuf.ProtoMember(2, Name = @"sig_op_contents")]
        public byte[] SigOpContents { get; set; }
        public bool ShouldSerializeSigOpContents() => SigOpContents != null;
        public void ResetSigOpContents() => SigOpContents = null;

        [ProtoBuf.ProtoMember(3, Name = @"operation_hash")]
        [System.ComponentModel.DefaultValue("")]
        public string OperationHash
        {
            get { return __pbn__OperationHash ?? ""; }
            set { __pbn__OperationHash = value; }
        }
        public bool ShouldSerializeOperationHash() => __pbn__OperationHash != null;
        public void ResetOperationHash() => __pbn__OperationHash = null;
        private string __pbn__OperationHash;

    }
}