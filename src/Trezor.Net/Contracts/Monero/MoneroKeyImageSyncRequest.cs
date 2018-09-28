namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"init")]
        public MoneroKeyImageExportInitRequest Init { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"step")]
        public MoneroKeyImageSyncStepRequest Step { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"final_msg")]
        public MoneroKeyImageSyncFinalRequest FinalMsg { get; set; }

    }
}