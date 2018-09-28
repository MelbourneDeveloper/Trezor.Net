namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class IdentityType : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"proto")]
        [System.ComponentModel.DefaultValue("")]
        public string Proto
        {
            get => __pbn__Proto ?? "";
            set => __pbn__Proto = value;
        }
        public bool ShouldSerializeProto() => __pbn__Proto != null;
        public void ResetProto() => __pbn__Proto = null;
        private string __pbn__Proto;

        [ProtoBuf.ProtoMember(2, Name = @"user")]
        [System.ComponentModel.DefaultValue("")]
        public string User
        {
            get => __pbn__User ?? "";
            set => __pbn__User = value;
        }
        public bool ShouldSerializeUser() => __pbn__User != null;
        public void ResetUser() => __pbn__User = null;
        private string __pbn__User;

        [ProtoBuf.ProtoMember(3, Name = @"host")]
        [System.ComponentModel.DefaultValue("")]
        public string Host
        {
            get => __pbn__Host ?? "";
            set => __pbn__Host = value;
        }
        public bool ShouldSerializeHost() => __pbn__Host != null;
        public void ResetHost() => __pbn__Host = null;
        private string __pbn__Host;

        [ProtoBuf.ProtoMember(4, Name = @"port")]
        [System.ComponentModel.DefaultValue("")]
        public string Port
        {
            get => __pbn__Port ?? "";
            set => __pbn__Port = value;
        }
        public bool ShouldSerializePort() => __pbn__Port != null;
        public void ResetPort() => __pbn__Port = null;
        private string __pbn__Port;

        [ProtoBuf.ProtoMember(5, Name = @"path")]
        [System.ComponentModel.DefaultValue("")]
        public string Path
        {
            get => __pbn__Path ?? "";
            set => __pbn__Path = value;
        }
        public bool ShouldSerializePath() => __pbn__Path != null;
        public void ResetPath() => __pbn__Path = null;
        private string __pbn__Path;

        [ProtoBuf.ProtoMember(6, Name = @"index")]
        [System.ComponentModel.DefaultValue(0)]
        public uint Index
        {
            get => __pbn__Index ?? 0;
            set => __pbn__Index = value;
        }
        public bool ShouldSerializeIndex() => __pbn__Index != null;
        public void ResetIndex() => __pbn__Index = null;
        private uint? __pbn__Index;

    }
}