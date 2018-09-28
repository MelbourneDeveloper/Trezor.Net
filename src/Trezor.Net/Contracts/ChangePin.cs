namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class ChangePin : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"remove")]
        public bool Remove
        {
            get { return __pbn__Remove.GetValueOrDefault(); }
            set { __pbn__Remove = value; }
        }
        public bool ShouldSerializeRemove() => __pbn__Remove != null;
        public void ResetRemove() => __pbn__Remove = null;
        private bool? __pbn__Remove;

    }
}