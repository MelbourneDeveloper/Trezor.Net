namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroKeyImageSyncRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"init")]
        public MoneroKeyImageExportInitRequest Init { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"step")]
        public MoneroKeyImageSyncStepRequest Step { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"final_msg")]
        public MoneroKeyImageSyncFinalRequest FinalMsg { get; set; }

    }
}