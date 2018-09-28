namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class LoadDevice : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"mnemonic")]
        [System.ComponentModel.DefaultValue("")]
        public string Mnemonic
        {
            get => __pbn__Mnemonic ?? "";
            set => __pbn__Mnemonic = value;
        }
        public bool ShouldSerializeMnemonic() => __pbn__Mnemonic != null;
        public void ResetMnemonic() => __pbn__Mnemonic = null;
        private string __pbn__Mnemonic;

        [ProtoBuf.ProtoMember(2, Name = @"node")]
        public Common.HDNodeType Node { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"pin")]
        [System.ComponentModel.DefaultValue("")]
        public string Pin
        {
            get => __pbn__Pin ?? "";
            set => __pbn__Pin = value;
        }
        public bool ShouldSerializePin() => __pbn__Pin != null;
        public void ResetPin() => __pbn__Pin = null;
        private string __pbn__Pin;

        [ProtoBuf.ProtoMember(4, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoBuf.ProtoMember(5, Name = @"language")]
        [System.ComponentModel.DefaultValue(@"english")]
        public string Language
        {
            get => __pbn__Language ?? @"english";
            set => __pbn__Language = value;
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoBuf.ProtoMember(6, Name = @"label")]
        [System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get => __pbn__Label ?? "";
            set => __pbn__Label = value;
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoBuf.ProtoMember(7, Name = @"skip_checksum")]
        public bool SkipChecksum
        {
            get => __pbn__SkipChecksum.GetValueOrDefault();
            set => __pbn__SkipChecksum = value;
        }
        public bool ShouldSerializeSkipChecksum() => __pbn__SkipChecksum != null;
        public void ResetSkipChecksum() => __pbn__SkipChecksum = null;
        private bool? __pbn__SkipChecksum;

        [ProtoBuf.ProtoMember(8, Name = @"u2f_counter")]
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