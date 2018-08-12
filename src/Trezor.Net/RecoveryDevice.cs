using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class RecoveryDevice
    {
        [ProtoMember(1, Name = @"word_count")]
        public uint WordCount
        {
            get => __pbn__WordCount.GetValueOrDefault();
            set => __pbn__WordCount = value;
        }
        public bool ShouldSerializeWordCount() => __pbn__WordCount != null;
        public void ResetWordCount() => __pbn__WordCount = null;
        private uint? __pbn__WordCount;

        [ProtoMember(2, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoMember(3, Name = @"pin_protection")]
        public bool PinProtection
        {
            get => __pbn__PinProtection.GetValueOrDefault();
            set => __pbn__PinProtection = value;
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [ProtoMember(4, Name = @"language")]
        [DefaultValue(@"english")]
        public string Language
        {
            get => __pbn__Language ?? @"english";
            set => __pbn__Language = value;
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoMember(5, Name = @"label")]
        [DefaultValue("")]
        public string Label
        {
            get => __pbn__Label ?? "";
            set => __pbn__Label = value;
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoMember(6, Name = @"enforce_wordlist")]
        public bool EnforceWordlist
        {
            get => __pbn__EnforceWordlist.GetValueOrDefault();
            set => __pbn__EnforceWordlist = value;
        }
        public bool ShouldSerializeEnforceWordlist() => __pbn__EnforceWordlist != null;
        public void ResetEnforceWordlist() => __pbn__EnforceWordlist = null;
        private bool? __pbn__EnforceWordlist;

        [ProtoMember(8, Name = @"type")]
        public uint Type
        {
            get => __pbn__Type.GetValueOrDefault();
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private uint? __pbn__Type;

        [ProtoMember(9, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get => __pbn__U2fCounter.GetValueOrDefault();
            set => __pbn__U2fCounter = value;
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

        [ProtoMember(10, Name = @"dry_run")]
        public bool DryRun
        {
            get => __pbn__DryRun.GetValueOrDefault();
            set => __pbn__DryRun = value;
        }
        public bool ShouldSerializeDryRun() => __pbn__DryRun != null;
        public void ResetDryRun() => __pbn__DryRun = null;
        private bool? __pbn__DryRun;

    }
}