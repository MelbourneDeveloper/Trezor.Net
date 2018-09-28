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
        public byte[] Nonce { get; set; }
        public bool ShouldSerializeNonce() => Nonce != null;
        public void ResetNonce() => Nonce = null;

        [ProtoBuf.ProtoMember(3, Name = @"gas_price")]
        public byte[] GasPrice { get; set; }
        public bool ShouldSerializeGasPrice() => GasPrice != null;
        public void ResetGasPrice() => GasPrice = null;

        [ProtoBuf.ProtoMember(4, Name = @"gas_limit")]
        public byte[] GasLimit { get; set; }
        public bool ShouldSerializeGasLimit() => GasLimit != null;
        public void ResetGasLimit() => GasLimit = null;

        [ProtoBuf.ProtoMember(5, Name = @"to")]
        public byte[] To { get; set; }
        public bool ShouldSerializeTo() => To != null;
        public void ResetTo() => To = null;

        [ProtoBuf.ProtoMember(6, Name = @"value")]
        public byte[] Value { get; set; }
        public bool ShouldSerializeValue() => Value != null;
        public void ResetValue() => Value = null;

        [ProtoBuf.ProtoMember(7, Name = @"data_initial_chunk")]
        public byte[] DataInitialChunk { get; set; }
        public bool ShouldSerializeDataInitialChunk() => DataInitialChunk != null;
        public void ResetDataInitialChunk() => DataInitialChunk = null;

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