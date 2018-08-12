using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class NEMTransfer
    {
        [ProtoMember(1, Name = @"recipient")]
        [DefaultValue("")]
        public string Recipient
        {
            get => __pbn__Recipient ?? "";
            set => __pbn__Recipient = value;
        }
        public bool ShouldSerializeRecipient() => __pbn__Recipient != null;
        public void ResetRecipient() => __pbn__Recipient = null;
        private string __pbn__Recipient;

        [ProtoMember(2, Name = @"amount")]
        public ulong Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

        [ProtoMember(3, Name = @"payload")]
        public byte[] Payload { get; set; }

        public bool ShouldSerializePayload() => Payload != null;
        public void ResetPayload() => Payload = null;

        [ProtoMember(4, Name = @"public_key")]
        public byte[] PublicKey { get; set; }

        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;

        [ProtoMember(5, Name = @"mosaics")]
        public List<NEMMosaic> Mosaics { get; } = new List<NEMMosaic>();

    }
}