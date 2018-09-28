namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class PassphraseAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"passphrase")]
        [System.ComponentModel.DefaultValue("")]
        public string Passphrase
        {
            get { return __pbn__Passphrase ?? ""; }
            set { __pbn__Passphrase = value; }
        }
        public bool ShouldSerializePassphrase() => __pbn__Passphrase != null;
        public void ResetPassphrase() => __pbn__Passphrase = null;
        private string __pbn__Passphrase;

        [ProtoBuf.ProtoMember(2, Name = @"state")]
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