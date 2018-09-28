namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class PassphraseStateRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state")]
        public byte[] State
        {
            get { return __pbn__State; }
            set { __pbn__State = value; }
        }
        public bool ShouldSerializeState() => __pbn__State != null;
        public void ResetState() => __pbn__State = null;
        private byte[] __pbn__State;

    }
}