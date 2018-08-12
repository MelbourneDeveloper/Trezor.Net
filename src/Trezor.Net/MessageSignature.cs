using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class MessageSignature
    {
        [ProtoMember(1, Name = @"address")]
        [DefaultValue("")]
        public string Address
        {
            get => __pbn__Address ?? "";
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;
    }
}