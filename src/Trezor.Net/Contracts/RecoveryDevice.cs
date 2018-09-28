namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class RecoveryDevice : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"word_count")]
        public uint WordCount
        {
            get { return __pbn__WordCount.GetValueOrDefault(); }
            set { __pbn__WordCount = value; }
        }
        public bool ShouldSerializeWordCount() => __pbn__WordCount != null;
        public void ResetWordCount() => __pbn__WordCount = null;
        private uint? __pbn__WordCount;

        [ProtoBuf.ProtoMember(2, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoBuf.ProtoMember(3, Name = @"pin_protection")]
        public bool PinProtection
        {
            get { return __pbn__PinProtection.GetValueOrDefault(); }
            set { __pbn__PinProtection = value; }
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [ProtoBuf.ProtoMember(4, Name = @"language")]
        [System.ComponentModel.DefaultValue(@"english")]
        public string Language
        {
            get { return __pbn__Language ?? @"english"; }
            set { __pbn__Language = value; }
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoBuf.ProtoMember(5, Name = @"label")]
        [System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get { return __pbn__Label ?? ""; }
            set { __pbn__Label = value; }
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoBuf.ProtoMember(6, Name = @"enforce_wordlist")]
        public bool EnforceWordlist
        {
            get { return __pbn__EnforceWordlist.GetValueOrDefault(); }
            set { __pbn__EnforceWordlist = value; }
        }
        public bool ShouldSerializeEnforceWordlist() => __pbn__EnforceWordlist != null;
        public void ResetEnforceWordlist() => __pbn__EnforceWordlist = null;
        private bool? __pbn__EnforceWordlist;

        [ProtoBuf.ProtoMember(8, Name = @"type")]
        [System.ComponentModel.DefaultValue(RecoveryDeviceType.RecoveryDeviceTypeScrambledWords)]
        public RecoveryDeviceType Type
        {
            get { return __pbn__Type ?? RecoveryDeviceType.RecoveryDeviceTypeScrambledWords; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private RecoveryDeviceType? __pbn__Type;

        [ProtoBuf.ProtoMember(9, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get { return __pbn__U2fCounter.GetValueOrDefault(); }
            set { __pbn__U2fCounter = value; }
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

        [ProtoBuf.ProtoMember(10, Name = @"dry_run")]
        public bool DryRun
        {
            get { return __pbn__DryRun.GetValueOrDefault(); }
            set { __pbn__DryRun = value; }
        }
        public bool ShouldSerializeDryRun() => __pbn__DryRun != null;
        public void ResetDryRun() => __pbn__DryRun = null;
        private bool? __pbn__DryRun;

        [ProtoBuf.ProtoContract()]
        public enum RecoveryDeviceType
        {
            [ProtoBuf.ProtoEnum(Name = @"RecoveryDeviceType_ScrambledWords")]
            RecoveryDeviceTypeScrambledWords = 0,
            [ProtoBuf.ProtoEnum(Name = @"RecoveryDeviceType_Matrix")]
            RecoveryDeviceTypeMatrix = 1,
        }

    }
}