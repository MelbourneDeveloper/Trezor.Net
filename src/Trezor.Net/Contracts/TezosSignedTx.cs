namespace Trezor.Net.Contracts.Tezos
{
    [global::ProtoBuf.ProtoContract()]
    public class TezosSignedTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Signature
        {
            get { return __pbn__Signature ?? ""; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private string __pbn__Signature;

        [global::ProtoBuf.ProtoMember(2, Name = @"sig_op_contents")]
        public byte[] SigOpContents
        {
            get { return __pbn__SigOpContents; }
            set { __pbn__SigOpContents = value; }
        }
        public bool ShouldSerializeSigOpContents() => __pbn__SigOpContents != null;
        public void ResetSigOpContents() => __pbn__SigOpContents = null;
        private byte[] __pbn__SigOpContents;

        [global::ProtoBuf.ProtoMember(3, Name = @"operation_hash")]
        [global::System.ComponentModel.DefaultValue("")]
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