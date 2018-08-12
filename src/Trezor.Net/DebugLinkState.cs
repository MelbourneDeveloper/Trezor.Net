using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class DebugLinkState
    {
        [ProtoMember(1, Name = @"layout")]
        public byte[] Layout { get; set; }

        public bool ShouldSerializeLayout() => Layout != null;
        public void ResetLayout() => Layout = null;

        [ProtoMember(2, Name = @"pin")]
        [DefaultValue("")]
        public string Pin
        {
            get => __pbn__Pin ?? "";
            set => __pbn__Pin = value;
        }
        public bool ShouldSerializePin() => __pbn__Pin != null;
        public void ResetPin() => __pbn__Pin = null;
        private string __pbn__Pin;

        [ProtoMember(3, Name = @"matrix")]
        [DefaultValue("")]
        public string Matrix
        {
            get => __pbn__Matrix ?? "";
            set => __pbn__Matrix = value;
        }
        public bool ShouldSerializeMatrix() => __pbn__Matrix != null;
        public void ResetMatrix() => __pbn__Matrix = null;
        private string __pbn__Matrix;

        [ProtoMember(4, Name = @"mnemonic")]
        [DefaultValue("")]
        public string Mnemonic
        {
            get => __pbn__Mnemonic ?? "";
            set => __pbn__Mnemonic = value;
        }
        public bool ShouldSerializeMnemonic() => __pbn__Mnemonic != null;
        public void ResetMnemonic() => __pbn__Mnemonic = null;
        private string __pbn__Mnemonic;

        [ProtoMember(5, Name = @"node")]
        public HDNodeType Node { get; set; }

        [ProtoMember(6, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoMember(7, Name = @"reset_word")]
        [DefaultValue("")]
        public string ResetWord
        {
            get => __pbn__ResetWord ?? "";
            set => __pbn__ResetWord = value;
        }
        public bool ShouldSerializeResetWord() => __pbn__ResetWord != null;
        public void ResetResetWord() => __pbn__ResetWord = null;
        private string __pbn__ResetWord;

        [ProtoMember(8, Name = @"reset_entropy")]
        public byte[] ResetEntropy { get; set; }

        public bool ShouldSerializeResetEntropy() => ResetEntropy != null;
        public void ResetResetEntropy() => ResetEntropy = null;

        [ProtoMember(9, Name = @"recovery_fake_word")]
        [DefaultValue("")]
        public string RecoveryFakeWord
        {
            get => __pbn__RecoveryFakeWord ?? "";
            set => __pbn__RecoveryFakeWord = value;
        }
        public bool ShouldSerializeRecoveryFakeWord() => __pbn__RecoveryFakeWord != null;
        public void ResetRecoveryFakeWord() => __pbn__RecoveryFakeWord = null;
        private string __pbn__RecoveryFakeWord;

        [ProtoMember(10, Name = @"recovery_word_pos")]
        public uint RecoveryWordPos
        {
            get => __pbn__RecoveryWordPos.GetValueOrDefault();
            set => __pbn__RecoveryWordPos = value;
        }
        public bool ShouldSerializeRecoveryWordPos() => __pbn__RecoveryWordPos != null;
        public void ResetRecoveryWordPos() => __pbn__RecoveryWordPos = null;
        private uint? __pbn__RecoveryWordPos;

    }
}