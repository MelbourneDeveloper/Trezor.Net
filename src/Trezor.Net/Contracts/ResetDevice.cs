namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class ResetDevice : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"display_random")]
        public bool DisplayRandom
        {
            get { return __pbn__DisplayRandom.GetValueOrDefault(); }
            set { __pbn__DisplayRandom = value; }
        }
        public bool ShouldSerializeDisplayRandom() => __pbn__DisplayRandom != null;
        public void ResetDisplayRandom() => __pbn__DisplayRandom = null;
        private bool? __pbn__DisplayRandom;

        [global::ProtoBuf.ProtoMember(2, Name = @"strength")]
        [global::System.ComponentModel.DefaultValue(256)]
        public uint Strength
        {
            get { return __pbn__Strength ?? 256; }
            set { __pbn__Strength = value; }
        }
        public bool ShouldSerializeStrength() => __pbn__Strength != null;
        public void ResetStrength() => __pbn__Strength = null;
        private uint? __pbn__Strength;

        [global::ProtoBuf.ProtoMember(3, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [global::ProtoBuf.ProtoMember(4, Name = @"pin_protection")]
        public bool PinProtection
        {
            get { return __pbn__PinProtection.GetValueOrDefault(); }
            set { __pbn__PinProtection = value; }
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [global::ProtoBuf.ProtoMember(5, Name = @"language")]
        [global::System.ComponentModel.DefaultValue(@"english")]
        public string Language
        {
            get { return __pbn__Language ?? @"english"; }
            set { __pbn__Language = value; }
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [global::ProtoBuf.ProtoMember(6, Name = @"label")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get { return __pbn__Label ?? ""; }
            set { __pbn__Label = value; }
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [global::ProtoBuf.ProtoMember(7, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get { return __pbn__U2fCounter.GetValueOrDefault(); }
            set { __pbn__U2fCounter = value; }
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

        [global::ProtoBuf.ProtoMember(8, Name = @"skip_backup")]
        public bool SkipBackup
        {
            get { return __pbn__SkipBackup.GetValueOrDefault(); }
            set { __pbn__SkipBackup = value; }
        }
        public bool ShouldSerializeSkipBackup() => __pbn__SkipBackup != null;
        public void ResetSkipBackup() => __pbn__SkipBackup = null;
        private bool? __pbn__SkipBackup;

    }
}