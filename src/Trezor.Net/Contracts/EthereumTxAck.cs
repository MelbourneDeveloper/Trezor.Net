namespace Trezor.Net.Contracts.Ethereum
{
    [global::ProtoBuf.ProtoContract()]
    public class EthereumTxAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"data_chunk")]
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