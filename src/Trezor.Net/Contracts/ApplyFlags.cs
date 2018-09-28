namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class ApplyFlags : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"flags")]
        public uint Flags
        {
            get { return __pbn__Flags.GetValueOrDefault(); }
            set { __pbn__Flags = value; }
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

    }
}