namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class Ping : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"message")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get { return __pbn__Message ?? ""; }
            set { __pbn__Message = value; }
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

        [global::ProtoBuf.ProtoMember(2, Name = @"button_protection")]
        public bool ButtonProtection
        {
            get { return __pbn__ButtonProtection.GetValueOrDefault(); }
            set { __pbn__ButtonProtection = value; }
        }
        public bool ShouldSerializeButtonProtection() => __pbn__ButtonProtection != null;
        public void ResetButtonProtection() => __pbn__ButtonProtection = null;
        private bool? __pbn__ButtonProtection;

        [global::ProtoBuf.ProtoMember(3, Name = @"pin_protection")]
        public bool PinProtection
        {
            get { return __pbn__PinProtection.GetValueOrDefault(); }
            set { __pbn__PinProtection = value; }
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [global::ProtoBuf.ProtoMember(4, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

    }
}