namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class CosiCommitment : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commitment")]
        public byte[] Commitment
        {
            get { return __pbn__Commitment; }
            set { __pbn__Commitment = value; }
        }
        public bool ShouldSerializeCommitment() => __pbn__Commitment != null;
        public void ResetCommitment() => __pbn__Commitment = null;
        private byte[] __pbn__Commitment;

        [global::ProtoBuf.ProtoMember(2, Name = @"pubkey")]
        public byte[] Pubkey
        {
            get { return __pbn__Pubkey; }
            set { __pbn__Pubkey = value; }
        }
        public bool ShouldSerializePubkey() => __pbn__Pubkey != null;
        public void ResetPubkey() => __pbn__Pubkey = null;
        private byte[] __pbn__Pubkey;

    }
}