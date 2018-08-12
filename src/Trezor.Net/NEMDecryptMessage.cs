using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class NEMDecryptMessage
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"network")]
        public uint Network
        {
            get => __pbn__Network.GetValueOrDefault();
            set => __pbn__Network = value;
        }
        public bool ShouldSerializeNetwork() => __pbn__Network != null;
        public void ResetNetwork() => __pbn__Network = null;
        private uint? __pbn__Network;

        [ProtoMember(3, Name = @"public_key")]
        public byte[] PublicKey { get; set; }

        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;

        [ProtoMember(4, Name = @"payload")]
        public byte[] Payload { get; set; }

        public bool ShouldSerializePayload() => Payload != null;
        public void ResetPayload() => Payload = null;
    }
}