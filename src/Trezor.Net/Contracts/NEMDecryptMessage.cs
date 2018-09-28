namespace Trezor.Net.Contracts.NEM
{
    [ProtoBuf.ProtoContract()]
    public class NEMDecryptMessage : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"network")]
        public uint Network
        {
            get { return __pbn__Network.GetValueOrDefault(); }
            set { __pbn__Network = value; }
        }
        public bool ShouldSerializeNetwork() => __pbn__Network != null;
        public void ResetNetwork() => __pbn__Network = null;
        private uint? __pbn__Network;

        [ProtoBuf.ProtoMember(3, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

        [ProtoBuf.ProtoMember(4, Name = @"payload")]
        public byte[] Payload
        {
            get { return __pbn__Payload; }
            set { __pbn__Payload = value; }
        }
        public bool ShouldSerializePayload() => __pbn__Payload != null;
        public void ResetPayload() => __pbn__Payload = null;
        private byte[] __pbn__Payload;

    }
}