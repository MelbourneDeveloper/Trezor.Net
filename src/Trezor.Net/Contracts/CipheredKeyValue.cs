namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class CipheredKeyValue : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"value")]
        public byte[] Value
        {
            get { return __pbn__Value; }
            set { __pbn__Value = value; }
        }
        public bool ShouldSerializeValue() => __pbn__Value != null;
        public void ResetValue() => __pbn__Value = null;
        private byte[] __pbn__Value;

    }
}