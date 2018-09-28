using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class EthereumSignTx
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"nonce")]
        public byte[] Nonce { get; set; }

        public bool ShouldSerializeNonce() => Nonce != null;
        public void ResetNonce() => Nonce = null;

        [ProtoMember(3, Name = @"gas_price")]
        public byte[] GasPrice { get; set; }

        public bool ShouldSerializeGasPrice() => GasPrice != null;
        public void ResetGasPrice() => GasPrice = null;

        [ProtoMember(4, Name = @"gas_limit")]
        public byte[] GasLimit { get; set; }

        public bool ShouldSerializeGasLimit() => GasLimit != null;
        public void ResetGasLimit() => GasLimit = null;

        [ProtoMember(5, Name = @"to")]
        public byte[] To { get; set; }

        public bool ShouldSerializeTo() => To != null;
        public void ResetTo() => To = null;

        [ProtoMember(6, Name = @"value")]
        public byte[] Value { get; set; }

        public bool ShouldSerializeValue() => Value != null;
        public void ResetValue() => Value = null;

        [ProtoMember(7, Name = @"data_initial_chunk")]
        public byte[] DataInitialChunk { get; set; }

        public bool ShouldSerializeDataInitialChunk() => DataInitialChunk != null;
        public void ResetDataInitialChunk() => DataInitialChunk = null;

        [ProtoMember(8, Name = @"data_length")]
        public uint DataLength
        {
            get => __pbn__DataLength.GetValueOrDefault();
            set => __pbn__DataLength = value;
        }
        public bool ShouldSerializeDataLength() => __pbn__DataLength != null;
        public void ResetDataLength() => __pbn__DataLength = null;
        private uint? __pbn__DataLength;

        [ProtoMember(9, Name = @"chain_id")]
        public uint ChainId
        {
            get => __pbn__ChainId.GetValueOrDefault();
            set => __pbn__ChainId = value;
        }
        public bool ShouldSerializeChainId() => __pbn__ChainId != null;
        public void ResetChainId() => __pbn__ChainId = null;
        private uint? __pbn__ChainId;

    }
}