namespace Trezor.Net.Contracts.Ripple
{
    [ProtoBuf.ProtoContract()]
    public class RippleSignedTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature { get; set; }
        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;

        [ProtoBuf.ProtoMember(2, Name = @"serialized_tx")]
        public byte[] SerializedTx { get; set; }
        public bool ShouldSerializeSerializedTx() => SerializedTx != null;
        public void ResetSerializedTx() => SerializedTx = null;
    }
}