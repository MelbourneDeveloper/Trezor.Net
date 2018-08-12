using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class CipherKeyValue
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"key")]
        [DefaultValue("")]
        public string Key
        {
            get => __pbn__Key ?? "";
            set => __pbn__Key = value;
        }
        public bool ShouldSerializeKey() => __pbn__Key != null;
        public void ResetKey() => __pbn__Key = null;
        private string __pbn__Key;

        [ProtoMember(3, Name = @"value")]
        public byte[] Value { get; set; }

        public bool ShouldSerializeValue() => Value != null;
        public void ResetValue() => Value = null;

        [ProtoMember(4, Name = @"encrypt")]
        public bool Encrypt
        {
            get => __pbn__Encrypt.GetValueOrDefault();
            set => __pbn__Encrypt = value;
        }
        public bool ShouldSerializeEncrypt() => __pbn__Encrypt != null;
        public void ResetEncrypt() => __pbn__Encrypt = null;
        private bool? __pbn__Encrypt;

        [ProtoMember(5, Name = @"ask_on_encrypt")]
        public bool AskOnEncrypt
        {
            get => __pbn__AskOnEncrypt.GetValueOrDefault();
            set => __pbn__AskOnEncrypt = value;
        }
        public bool ShouldSerializeAskOnEncrypt() => __pbn__AskOnEncrypt != null;
        public void ResetAskOnEncrypt() => __pbn__AskOnEncrypt = null;
        private bool? __pbn__AskOnEncrypt;

        [ProtoMember(6, Name = @"ask_on_decrypt")]
        public bool AskOnDecrypt
        {
            get => __pbn__AskOnDecrypt.GetValueOrDefault();
            set => __pbn__AskOnDecrypt = value;
        }
        public bool ShouldSerializeAskOnDecrypt() => __pbn__AskOnDecrypt != null;
        public void ResetAskOnDecrypt() => __pbn__AskOnDecrypt = null;
        private bool? __pbn__AskOnDecrypt;

        [ProtoMember(7, Name = @"iv")]
        public byte[] Iv { get; set; }

        public bool ShouldSerializeIv() => Iv != null;
        public void ResetIv() => Iv = null;
    }
}