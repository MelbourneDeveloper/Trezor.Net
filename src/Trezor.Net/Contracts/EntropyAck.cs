namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class EntropyAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"entropy")]
        public byte[] Entropy
        {
            get { return __pbn__Entropy; }
            set { __pbn__Entropy = value; }
        }
        public bool ShouldSerializeEntropy() => __pbn__Entropy != null;
        public void ResetEntropy() => __pbn__Entropy = null;
        private byte[] __pbn__Entropy;

    }
}