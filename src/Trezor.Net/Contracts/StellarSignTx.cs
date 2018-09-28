namespace Trezor.Net.Contracts.Stellar
{
    [global::ProtoBuf.ProtoContract()]
    public class StellarSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"network_passphrase")]
        [global::System.ComponentModel.DefaultValue("")]
        public string NetworkPassphrase
        {
            get { return __pbn__NetworkPassphrase ?? ""; }
            set { __pbn__NetworkPassphrase = value; }
        }
        public bool ShouldSerializeNetworkPassphrase() => __pbn__NetworkPassphrase != null;
        public void ResetNetworkPassphrase() => __pbn__NetworkPassphrase = null;
        private string __pbn__NetworkPassphrase;

        [global::ProtoBuf.ProtoMember(4, Name = @"source_account")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SourceAccount
        {
            get { return __pbn__SourceAccount ?? ""; }
            set { __pbn__SourceAccount = value; }
        }
        public bool ShouldSerializeSourceAccount() => __pbn__SourceAccount != null;
        public void ResetSourceAccount() => __pbn__SourceAccount = null;
        private string __pbn__SourceAccount;

        [global::ProtoBuf.ProtoMember(5, Name = @"fee")]
        public uint Fee
        {
            get { return __pbn__Fee.GetValueOrDefault(); }
            set { __pbn__Fee = value; }
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private uint? __pbn__Fee;

        [global::ProtoBuf.ProtoMember(6, Name = @"sequence_number")]
        public ulong SequenceNumber
        {
            get { return __pbn__SequenceNumber.GetValueOrDefault(); }
            set { __pbn__SequenceNumber = value; }
        }
        public bool ShouldSerializeSequenceNumber() => __pbn__SequenceNumber != null;
        public void ResetSequenceNumber() => __pbn__SequenceNumber = null;
        private ulong? __pbn__SequenceNumber;

        [global::ProtoBuf.ProtoMember(8, Name = @"timebounds_start")]
        public uint TimeboundsStart
        {
            get { return __pbn__TimeboundsStart.GetValueOrDefault(); }
            set { __pbn__TimeboundsStart = value; }
        }
        public bool ShouldSerializeTimeboundsStart() => __pbn__TimeboundsStart != null;
        public void ResetTimeboundsStart() => __pbn__TimeboundsStart = null;
        private uint? __pbn__TimeboundsStart;

        [global::ProtoBuf.ProtoMember(9, Name = @"timebounds_end")]
        public uint TimeboundsEnd
        {
            get { return __pbn__TimeboundsEnd.GetValueOrDefault(); }
            set { __pbn__TimeboundsEnd = value; }
        }
        public bool ShouldSerializeTimeboundsEnd() => __pbn__TimeboundsEnd != null;
        public void ResetTimeboundsEnd() => __pbn__TimeboundsEnd = null;
        private uint? __pbn__TimeboundsEnd;

        [global::ProtoBuf.ProtoMember(10, Name = @"memo_type")]
        public uint MemoType
        {
            get { return __pbn__MemoType.GetValueOrDefault(); }
            set { __pbn__MemoType = value; }
        }
        public bool ShouldSerializeMemoType() => __pbn__MemoType != null;
        public void ResetMemoType() => __pbn__MemoType = null;
        private uint? __pbn__MemoType;

        [global::ProtoBuf.ProtoMember(11, Name = @"memo_text")]
        [global::System.ComponentModel.DefaultValue("")]
        public string MemoText
        {
            get { return __pbn__MemoText ?? ""; }
            set { __pbn__MemoText = value; }
        }
        public bool ShouldSerializeMemoText() => __pbn__MemoText != null;
        public void ResetMemoText() => __pbn__MemoText = null;
        private string __pbn__MemoText;

        [global::ProtoBuf.ProtoMember(12, Name = @"memo_id")]
        public ulong MemoId
        {
            get { return __pbn__MemoId.GetValueOrDefault(); }
            set { __pbn__MemoId = value; }
        }
        public bool ShouldSerializeMemoId() => __pbn__MemoId != null;
        public void ResetMemoId() => __pbn__MemoId = null;
        private ulong? __pbn__MemoId;

        [global::ProtoBuf.ProtoMember(13, Name = @"memo_hash")]
        public byte[] MemoHash
        {
            get { return __pbn__MemoHash; }
            set { __pbn__MemoHash = value; }
        }
        public bool ShouldSerializeMemoHash() => __pbn__MemoHash != null;
        public void ResetMemoHash() => __pbn__MemoHash = null;
        private byte[] __pbn__MemoHash;

        [global::ProtoBuf.ProtoMember(14, Name = @"num_operations")]
        public uint NumOperations
        {
            get { return __pbn__NumOperations.GetValueOrDefault(); }
            set { __pbn__NumOperations = value; }
        }
        public bool ShouldSerializeNumOperations() => __pbn__NumOperations != null;
        public void ResetNumOperations() => __pbn__NumOperations = null;
        private uint? __pbn__NumOperations;

    }
}