namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncStepRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tdis")]
        public global::System.Collections.Generic.List<MoneroTransferDetails> Tdes { get; } = new global::System.Collections.Generic.List<MoneroTransferDetails>();

        [global::ProtoBuf.ProtoContract()]
        public class MoneroTransferDetails : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"out_key")]
            public byte[] OutKey
            {
                get { return __pbn__OutKey; }
                set { __pbn__OutKey = value; }
            }
            public bool ShouldSerializeOutKey() => __pbn__OutKey != null;
            public void ResetOutKey() => __pbn__OutKey = null;
            private byte[] __pbn__OutKey;

            [global::ProtoBuf.ProtoMember(2, Name = @"tx_pub_key")]
            public byte[] TxPubKey
            {
                get { return __pbn__TxPubKey; }
                set { __pbn__TxPubKey = value; }
            }
            public bool ShouldSerializeTxPubKey() => __pbn__TxPubKey != null;
            public void ResetTxPubKey() => __pbn__TxPubKey = null;
            private byte[] __pbn__TxPubKey;

            [global::ProtoBuf.ProtoMember(3, Name = @"additional_tx_pub_keys")]
            public global::System.Collections.Generic.List<byte[]> AdditionalTxPubKeys { get; } = new global::System.Collections.Generic.List<byte[]>();

            [global::ProtoBuf.ProtoMember(4, Name = @"internal_output_index")]
            public ulong InternalOutputIndex
            {
                get { return __pbn__InternalOutputIndex.GetValueOrDefault(); }
                set { __pbn__InternalOutputIndex = value; }
            }
            public bool ShouldSerializeInternalOutputIndex() => __pbn__InternalOutputIndex != null;
            public void ResetInternalOutputIndex() => __pbn__InternalOutputIndex = null;
            private ulong? __pbn__InternalOutputIndex;

        }

    }
}