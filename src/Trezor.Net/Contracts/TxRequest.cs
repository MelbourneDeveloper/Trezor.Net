namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public class TxRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1)]
        [System.ComponentModel.DefaultValue(RequestType.Txinput)]
        public RequestType request_type
        {
            get { return __pbn__request_type ?? RequestType.Txinput; }
            set { __pbn__request_type = value; }
        }
        public bool ShouldSerializerequest_type() => __pbn__request_type != null;
        public void Resetrequest_type() => __pbn__request_type = null;
        private RequestType? __pbn__request_type;

        [ProtoBuf.ProtoMember(2, Name = @"details")]
        public TxRequestDetailsType Details { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"serialized")]
        public TxRequestSerializedType Serialized { get; set; }

        [ProtoBuf.ProtoContract()]
        public class TxRequestDetailsType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"request_index")]
            public uint RequestIndex
            {
                get { return __pbn__RequestIndex.GetValueOrDefault(); }
                set { __pbn__RequestIndex = value; }
            }
            public bool ShouldSerializeRequestIndex() => __pbn__RequestIndex != null;
            public void ResetRequestIndex() => __pbn__RequestIndex = null;
            private uint? __pbn__RequestIndex;

            [ProtoBuf.ProtoMember(2, Name = @"tx_hash")]
            public byte[] TxHash
            {
                get { return __pbn__TxHash; }
                set { __pbn__TxHash = value; }
            }
            public bool ShouldSerializeTxHash() => __pbn__TxHash != null;
            public void ResetTxHash() => __pbn__TxHash = null;
            private byte[] __pbn__TxHash;

            [ProtoBuf.ProtoMember(3, Name = @"extra_data_len")]
            public uint ExtraDataLen
            {
                get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
                set { __pbn__ExtraDataLen = value; }
            }
            public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
            public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
            private uint? __pbn__ExtraDataLen;

            [ProtoBuf.ProtoMember(4, Name = @"extra_data_offset")]
            public uint ExtraDataOffset
            {
                get { return __pbn__ExtraDataOffset.GetValueOrDefault(); }
                set { __pbn__ExtraDataOffset = value; }
            }
            public bool ShouldSerializeExtraDataOffset() => __pbn__ExtraDataOffset != null;
            public void ResetExtraDataOffset() => __pbn__ExtraDataOffset = null;
            private uint? __pbn__ExtraDataOffset;

        }

        [ProtoBuf.ProtoContract()]
        public class TxRequestSerializedType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"signature_index")]
            public uint SignatureIndex
            {
                get { return __pbn__SignatureIndex.GetValueOrDefault(); }
                set { __pbn__SignatureIndex = value; }
            }
            public bool ShouldSerializeSignatureIndex() => __pbn__SignatureIndex != null;
            public void ResetSignatureIndex() => __pbn__SignatureIndex = null;
            private uint? __pbn__SignatureIndex;

            [ProtoBuf.ProtoMember(2, Name = @"signature")]
            public byte[] Signature
            {
                get { return __pbn__Signature; }
                set { __pbn__Signature = value; }
            }
            public bool ShouldSerializeSignature() => __pbn__Signature != null;
            public void ResetSignature() => __pbn__Signature = null;
            private byte[] __pbn__Signature;

            [ProtoBuf.ProtoMember(3, Name = @"serialized_tx")]
            public byte[] SerializedTx
            {
                get { return __pbn__SerializedTx; }
                set { __pbn__SerializedTx = value; }
            }
            public bool ShouldSerializeSerializedTx() => __pbn__SerializedTx != null;
            public void ResetSerializedTx() => __pbn__SerializedTx = null;
            private byte[] __pbn__SerializedTx;

        }

        [ProtoBuf.ProtoContract()]
        public enum RequestType
        {
            [ProtoBuf.ProtoEnum(Name = @"TXINPUT")]
            Txinput = 0,
            [ProtoBuf.ProtoEnum(Name = @"TXOUTPUT")]
            Txoutput = 1,
            [ProtoBuf.ProtoEnum(Name = @"TXMETA")]
            Txmeta = 2,
            [ProtoBuf.ProtoEnum(Name = @"TXFINISHED")]
            Txfinished = 3,
            [ProtoBuf.ProtoEnum(Name = @"TXEXTRADATA")]
            Txextradata = 4,
        }

    }
}