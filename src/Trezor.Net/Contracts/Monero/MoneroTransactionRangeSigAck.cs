namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionRangeSigAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"rsig_data")]
        public MoneroTransactionRsigData RsigData { get; set; }

    }
}