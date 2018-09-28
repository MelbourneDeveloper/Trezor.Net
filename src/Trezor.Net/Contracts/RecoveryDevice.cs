namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class RecoveryDevice : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"word_count")]
        public uint WordCount
        {
            get { return __pbn__WordCount.GetValueOrDefault(); }
            set { __pbn__WordCount = value; }
        }
        public bool ShouldSerializeWordCount() => __pbn__WordCount != null;
        public void ResetWordCount() => __pbn__WordCount = null;
        private uint? __pbn__WordCount;

        [global::ProtoBuf.ProtoMember(2, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [global::ProtoBuf.ProtoMember(3, Name = @"pin_protection")]
        public bool PinProtection
        {
            get { return __pbn__PinProtection.GetValueOrDefault(); }
            set { __pbn__PinProtection = value; }
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [global::ProtoBuf.ProtoMember(4, Name = @"language")]
        [global::System.ComponentModel.DefaultValue(@"english")]
        public string Language
        {
            get { return __pbn__Language ?? @"english"; }
            set { __pbn__Language = value; }
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [global::ProtoBuf.ProtoMember(5, Name = @"label")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get { return __pbn__Label ?? ""; }
            set { __pbn__Label = value; }
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [global::ProtoBuf.ProtoMember(6, Name = @"enforce_wordlist")]
        public bool EnforceWordlist
        {
            get { return __pbn__EnforceWordlist.GetValueOrDefault(); }
            set { __pbn__EnforceWordlist = value; }
        }
        public bool ShouldSerializeEnforceWordlist() => __pbn__EnforceWordlist != null;
        public void ResetEnforceWordlist() => __pbn__EnforceWordlist = null;
        private bool? __pbn__EnforceWordlist;

        [global::ProtoBuf.ProtoMember(8, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(RecoveryDeviceType.RecoveryDeviceTypeScrambledWords)]
        public RecoveryDeviceType Type
        {
            get { return __pbn__Type ?? RecoveryDeviceType.RecoveryDeviceTypeScrambledWords; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private RecoveryDeviceType? __pbn__Type;

        [global::ProtoBuf.ProtoMember(9, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get { return __pbn__U2fCounter.GetValueOrDefault(); }
            set { __pbn__U2fCounter = value; }
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

        [global::ProtoBuf.ProtoMember(10, Name = @"dry_run")]
        public bool DryRun
        {
            get { return __pbn__DryRun.GetValueOrDefault(); }
            set { __pbn__DryRun = value; }
        }
        public bool ShouldSerializeDryRun() => __pbn__DryRun != null;
        public void ResetDryRun() => __pbn__DryRun = null;
        private bool? __pbn__DryRun;

        [global::ProtoBuf.ProtoContract()]
        public enum RecoveryDeviceType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"RecoveryDeviceType_ScrambledWords")]
            RecoveryDeviceTypeScrambledWords = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"RecoveryDeviceType_Matrix")]
            RecoveryDeviceTypeMatrix = 1,
        }

    }
}