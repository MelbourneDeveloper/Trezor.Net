namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class Ping : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"message")]
        [System.ComponentModel.DefaultValue("")]
        public string Message
        {
            get => __pbn__Message ?? "";
            set => __pbn__Message = value;
        }
        public bool ShouldSerializeMessage() => __pbn__Message != null;
        public void ResetMessage() => __pbn__Message = null;
        private string __pbn__Message;

        [ProtoBuf.ProtoMember(2, Name = @"button_protection")]
        public bool ButtonProtection
        {
            get => __pbn__ButtonProtection.GetValueOrDefault();
            set => __pbn__ButtonProtection = value;
        }
        public bool ShouldSerializeButtonProtection() => __pbn__ButtonProtection != null;
        public void ResetButtonProtection() => __pbn__ButtonProtection = null;
        private bool? __pbn__ButtonProtection;

        [ProtoBuf.ProtoMember(3, Name = @"pin_protection")]
        public bool PinProtection
        {
            get => __pbn__PinProtection.GetValueOrDefault();
            set => __pbn__PinProtection = value;
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [ProtoBuf.ProtoMember(4, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

    }
}