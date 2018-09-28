namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public class TxRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(RequestType.Txinput)]
        public RequestType request_type
        {
            get { return __pbn__request_type ?? RequestType.Txinput; }
            set { __pbn__request_type = value; }
        }
        public bool ShouldSerializerequest_type() => __pbn__request_type != null;
        public void Resetrequest_type() => __pbn__request_type = null;
        private RequestType? __pbn__request_type;

        [global::ProtoBuf.ProtoMember(2, Name = @"details")]
        public TxRequestDetailsType Details { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"serialized")]
        public TxRequestSerializedType Serialized { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class TxRequestDetailsType : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"request_index")]
            public uint RequestIndex
            {
                get { return __pbn__RequestIndex.GetValueOrDefault(); }
                set { __pbn__RequestIndex = value; }
            }
            public bool ShouldSerializeRequestIndex() => __pbn__RequestIndex != null;
            public void ResetRequestIndex() => __pbn__RequestIndex = null;
            private uint? __pbn__RequestIndex;

            [global::ProtoBuf.ProtoMember(2, Name = @"tx_hash")]
            public byte[] TxHash
            {
                get { return __pbn__TxHash; }
                set { __pbn__TxHash = value; }
            }
            public bool ShouldSerializeTxHash() => __pbn__TxHash != null;
            public void ResetTxHash() => __pbn__TxHash = null;
            private byte[] __pbn__TxHash;

            [global::ProtoBuf.ProtoMember(3, Name = @"extra_data_len")]
            public uint ExtraDataLen
            {
                get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
                set { __pbn__ExtraDataLen = value; }
            }
            public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
            public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
            private uint? __pbn__ExtraDataLen;

            [global::ProtoBuf.ProtoMember(4, Name = @"extra_data_offset")]
            public uint ExtraDataOffset
            {
                get { return __pbn__ExtraDataOffset.GetValueOrDefault(); }
                set { __pbn__ExtraDataOffset = value; }
            }
            public bool ShouldSerializeExtraDataOffset() => __pbn__ExtraDataOffset != null;
            public void ResetExtraDataOffset() => __pbn__ExtraDataOffset = null;
            private uint? __pbn__ExtraDataOffset;

        }

        [global::ProtoBuf.ProtoContract()]
        public class TxRequestSerializedType : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"signature_index")]
            public uint SignatureIndex
            {
                get { return __pbn__SignatureIndex.GetValueOrDefault(); }
                set { __pbn__SignatureIndex = value; }
            }
            public bool ShouldSerializeSignatureIndex() => __pbn__SignatureIndex != null;
            public void ResetSignatureIndex() => __pbn__SignatureIndex = null;
            private uint? __pbn__SignatureIndex;

            [global::ProtoBuf.ProtoMember(2, Name = @"signature")]
            public byte[] Signature
            {
                get { return __pbn__Signature; }
                set { __pbn__Signature = value; }
            }
            public bool ShouldSerializeSignature() => __pbn__Signature != null;
            public void ResetSignature() => __pbn__Signature = null;
            private byte[] __pbn__Signature;

            [global::ProtoBuf.ProtoMember(3, Name = @"serialized_tx")]
            public byte[] SerializedTx
            {
                get { return __pbn__SerializedTx; }
                set { __pbn__SerializedTx = value; }
            }
            public bool ShouldSerializeSerializedTx() => __pbn__SerializedTx != null;
            public void ResetSerializedTx() => __pbn__SerializedTx = null;
            private byte[] __pbn__SerializedTx;

        }

        [global::ProtoBuf.ProtoContract()]
        public enum RequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"TXINPUT")]
            Txinput = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"TXOUTPUT")]
            Txoutput = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"TXMETA")]
            Txmeta = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"TXFINISHED")]
            Txfinished = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"TXEXTRADATA")]
            Txextradata = 4,
        }

    }
}