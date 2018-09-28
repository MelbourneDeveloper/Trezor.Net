namespace Trezor.Net.Contracts.Ethereum
{
    [ProtoBuf.ProtoContract()]
    public class EthereumTxAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"data_chunk")]
        public byte[] DataChunk
        {
            get { return __pbn__DataChunk; }
            set { __pbn__DataChunk = value; }
        }
        public bool ShouldSerializeDataChunk() => __pbn__DataChunk != null;
        public void ResetDataChunk() => __pbn__DataChunk = null;
        private byte[] __pbn__DataChunk;

    }
}