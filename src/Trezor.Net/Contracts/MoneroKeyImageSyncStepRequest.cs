namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncStepRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tdis")]
        public System.Collections.Generic.List<MoneroTransferDetails> Tdes { get; } = new System.Collections.Generic.List<MoneroTransferDetails>();

        [ProtoBuf.ProtoContract()]
        public class MoneroTransferDetails : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"out_key")]
            public byte[] OutKey
            {
                get { return __pbn__OutKey; }
                set { __pbn__OutKey = value; }
            }
            public bool ShouldSerializeOutKey() => __pbn__OutKey != null;
            public void ResetOutKey() => __pbn__OutKey = null;
            private byte[] __pbn__OutKey;

            [ProtoBuf.ProtoMember(2, Name = @"tx_pub_key")]
            public byte[] TxPubKey
            {
                get { return __pbn__TxPubKey; }
                set { __pbn__TxPubKey = value; }
            }
            public bool ShouldSerializeTxPubKey() => __pbn__TxPubKey != null;
            public void ResetTxPubKey() => __pbn__TxPubKey = null;
            private byte[] __pbn__TxPubKey;

            [ProtoBuf.ProtoMember(3, Name = @"additional_tx_pub_keys")]
            public System.Collections.Generic.List<byte[]> AdditionalTxPubKeys { get; } = new System.Collections.Generic.List<byte[]>();

            [ProtoBuf.ProtoMember(4, Name = @"internal_output_index")]
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