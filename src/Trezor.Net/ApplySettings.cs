using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class ApplySettings
    {
        [ProtoMember(1, Name = @"language")]
        [DefaultValue("")]
        public string Language
        {
            get => __pbn__Language ?? "";
            set => __pbn__Language = value;
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoMember(2, Name = @"label")]
        [DefaultValue("")]
        public string Label
        {
            get => __pbn__Label ?? "";
            set => __pbn__Label = value;
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoMember(3, Name = @"use_passphrase")]
        public bool UsePassphrase
        {
            get => __pbn__UsePassphrase.GetValueOrDefault();
            set => __pbn__UsePassphrase = value;
        }
        public bool ShouldSerializeUsePassphrase() => __pbn__UsePassphrase != null;
        public void ResetUsePassphrase() => __pbn__UsePassphrase = null;
        private bool? __pbn__UsePassphrase;

        [ProtoMember(4, Name = @"homescreen")]
        public byte[] Homescreen { get; set; }

        public bool ShouldSerializeHomescreen() => Homescreen != null;
        public void ResetHomescreen() => Homescreen = null;
    }
}