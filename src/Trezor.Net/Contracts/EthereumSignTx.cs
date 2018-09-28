namespace Trezor.Net.Contracts.Ethereum
{
    [ProtoBuf.ProtoContract()]
    public class EthereumSignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"nonce")]
        public byte[] Nonce
        {
            get { return __pbn__Nonce; }
            set { __pbn__Nonce = value; }
        }
        public bool ShouldSerializeNonce() => __pbn__Nonce != null;
        public void ResetNonce() => __pbn__Nonce = null;
        private byte[] __pbn__Nonce;

        [ProtoBuf.ProtoMember(3, Name = @"gas_price")]
        public byte[] GasPrice
        {
            get { return __pbn__GasPrice; }
            set { __pbn__GasPrice = value; }
        }
        public bool ShouldSerializeGasPrice() => __pbn__GasPrice != null;
        public void ResetGasPrice() => __pbn__GasPrice = null;
        private byte[] __pbn__GasPrice;

        [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
        public byte[] GasLimit
        {
            get { return __pbn__GasLimit; }
            set { __pbn__GasLimit = value; }
        }
        public bool ShouldSerializeGasLimit() => __pbn__GasLimit != null;
        public void ResetGasLimit() => __pbn__GasLimit = null;
        private byte[] __pbn__GasLimit;

        [ProtoBuf.ProtoMember(5, Name = @"to")]
        public byte[] To
        {
            get { return __pbn__To; }
            set { __pbn__To = value; }
        }
        public bool ShouldSerializeTo() => __pbn__To != null;
        public void ResetTo() => __pbn__To = null;
        private byte[] __pbn__To;

        [ProtoBuf.ProtoMember(6, Name = @"value")]
        public byte[] Value
        {
            get { return __pbn__Value; }
            set { __pbn__Value = value; }
        }
        public bool ShouldSerializeValue() => __pbn__Value != null;
        public void ResetValue() => __pbn__Value = null;
        private byte[] __pbn__Value;

        [ProtoBuf.ProtoMember(7, Name = @"data_initial_chunk")]
        public byte[] DataInitialChunk
        {
            get { return __pbn__DataInitialChunk; }
            set { __pbn__DataInitialChunk = value; }
        }
        public bool ShouldSerializeDataInitialChunk() => __pbn__DataInitialChunk != null;
        public void ResetDataInitialChunk() => __pbn__DataInitialChunk = null;
        private byte[] __pbn__DataInitialChunk;

        [ProtoBuf.ProtoMember(8, Name = @"data_length")]
        public uint DataLength
        {
            get { return __pbn__DataLength.GetValueOrDefault(); }
            set { __pbn__DataLength = value; }
        }
        public bool ShouldSerializeDataLength() => __pbn__DataLength != null;
        public void ResetDataLength() => __pbn__DataLength = null;
        private uint? __pbn__DataLength;

        [ProtoBuf.ProtoMember(9, Name = @"chain_id")]
        public uint ChainId
        {
            get { return __pbn__ChainId.GetValueOrDefault(); }
            set { __pbn__ChainId = value; }
        }
        public bool ShouldSerializeChainId() => __pbn__ChainId != null;
        public void ResetChainId() => __pbn__ChainId = null;
        private uint? __pbn__ChainId;

        [ProtoBuf.ProtoMember(10, Name = @"tx_type")]
        public uint TxType
        {
            get { return __pbn__TxType.GetValueOrDefault(); }
            set { __pbn__TxType = value; }
        }
        public bool ShouldSerializeTxType() => __pbn__TxType != null;
        public void ResetTxType() => __pbn__TxType = null;
        private uint? __pbn__TxType;

    }
}