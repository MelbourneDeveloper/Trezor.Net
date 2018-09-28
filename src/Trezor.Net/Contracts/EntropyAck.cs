namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class EntropyAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"entropy")]
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