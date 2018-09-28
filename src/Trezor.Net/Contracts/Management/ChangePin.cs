namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class ChangePin : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"remove")]
        public bool Remove
        {
            get => __pbn__Remove.GetValueOrDefault();
            set => __pbn__Remove = value;
        }
        public bool ShouldSerializeRemove() => __pbn__Remove != null;
        public void ResetRemove() => __pbn__Remove = null;
        private bool? __pbn__Remove;

    }
}