using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class LoadDevice
    {
        [ProtoMember(1, Name = @"mnemonic")]
        [DefaultValue("")]
        public string Mnemonic
        {
            get => __pbn__Mnemonic ?? "";
            set => __pbn__Mnemonic = value;
        }
        public bool ShouldSerializeMnemonic() => __pbn__Mnemonic != null;
        public void ResetMnemonic() => __pbn__Mnemonic = null;
        private string __pbn__Mnemonic;

        [ProtoMember(2, Name = @"node")]
        public HDNodeType Node { get; set; }

        [ProtoMember(3, Name = @"pin")]
        [DefaultValue("")]
        public string Pin
        {
            get => __pbn__Pin ?? "";
            set => __pbn__Pin = value;
        }
        public bool ShouldSerializePin() => __pbn__Pin != null;
        public void ResetPin() => __pbn__Pin = null;
        private string __pbn__Pin;

        [ProtoMember(4, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoMember(5, Name = @"language")]
        [DefaultValue(@"english")]
        public string Language
        {
            get => __pbn__Language ?? @"english";
            set => __pbn__Language = value;
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoMember(6, Name = @"label")]
        [DefaultValue("")]
        public string Label
        {
            get => __pbn__Label ?? "";
            set => __pbn__Label = value;
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoMember(7, Name = @"skip_checksum")]
        public bool SkipChecksum
        {
            get => __pbn__SkipChecksum.GetValueOrDefault();
            set => __pbn__SkipChecksum = value;
        }
        public bool ShouldSerializeSkipChecksum() => __pbn__SkipChecksum != null;
        public void ResetSkipChecksum() => __pbn__SkipChecksum = null;
        private bool? __pbn__SkipChecksum;

        [ProtoMember(8, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get => __pbn__U2fCounter.GetValueOrDefault();
            set => __pbn__U2fCounter = value;
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

    }
}