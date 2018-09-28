namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class ApplySettings : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"language")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Language
        {
            get { return __pbn__Language ?? ""; }
            set { __pbn__Language = value; }
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [global::ProtoBuf.ProtoMember(2, Name = @"label")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Label
        {
            get { return __pbn__Label ?? ""; }
            set { __pbn__Label = value; }
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [global::ProtoBuf.ProtoMember(3, Name = @"use_passphrase")]
        public bool UsePassphrase
        {
            get { return __pbn__UsePassphrase.GetValueOrDefault(); }
            set { __pbn__UsePassphrase = value; }
        }
        public bool ShouldSerializeUsePassphrase() => __pbn__UsePassphrase != null;
        public void ResetUsePassphrase() => __pbn__UsePassphrase = null;
        private bool? __pbn__UsePassphrase;

        [global::ProtoBuf.ProtoMember(4, Name = @"homescreen")]
        public byte[] Homescreen
        {
            get { return __pbn__Homescreen; }
            set { __pbn__Homescreen = value; }
        }
        public bool ShouldSerializeHomescreen() => __pbn__Homescreen != null;
        public void ResetHomescreen() => __pbn__Homescreen = null;
        private byte[] __pbn__Homescreen;

        [global::ProtoBuf.ProtoMember(5, Name = @"passphrase_source")]
        [global::System.ComponentModel.DefaultValue(PassphraseSourceType.Ask)]
        public PassphraseSourceType PassphraseSource
        {
            get { return __pbn__PassphraseSource ?? PassphraseSourceType.Ask; }
            set { __pbn__PassphraseSource = value; }
        }
        public bool ShouldSerializePassphraseSource() => __pbn__PassphraseSource != null;
        public void ResetPassphraseSource() => __pbn__PassphraseSource = null;
        private PassphraseSourceType? __pbn__PassphraseSource;

        [global::ProtoBuf.ProtoMember(6, Name = @"auto_lock_delay_ms")]
        public uint AutoLockDelayMs
        {
            get { return __pbn__AutoLockDelayMs.GetValueOrDefault(); }
            set { __pbn__AutoLockDelayMs = value; }
        }
        public bool ShouldSerializeAutoLockDelayMs() => __pbn__AutoLockDelayMs != null;
        public void ResetAutoLockDelayMs() => __pbn__AutoLockDelayMs = null;
        private uint? __pbn__AutoLockDelayMs;

        [global::ProtoBuf.ProtoContract()]
        public enum PassphraseSourceType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ASK")]
            Ask = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"DEVICE")]
            Device = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"HOST")]
            Host = 2,
        }

    }
}