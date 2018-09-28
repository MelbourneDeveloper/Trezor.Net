namespace Trezor.Net.Contracts.NEM
{
    [global::ProtoBuf.ProtoContract()]
    public class NEMDecryptMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"network")]
        public uint Network
        {
            get { return __pbn__Network.GetValueOrDefault(); }
            set { __pbn__Network = value; }
        }
        public bool ShouldSerializeNetwork() => __pbn__Network != null;
        public void ResetNetwork() => __pbn__Network = null;
        private uint? __pbn__Network;

        [global::ProtoBuf.ProtoMember(3, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

        [global::ProtoBuf.ProtoMember(4, Name = @"payload")]
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