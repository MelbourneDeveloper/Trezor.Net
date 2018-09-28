namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class IdentityType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proto")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Proto
        {
            get { return __pbn__Proto ?? ""; }
            set { __pbn__Proto = value; }
        }
        public bool ShouldSerializeProto() => __pbn__Proto != null;
        public void ResetProto() => __pbn__Proto = null;
        private string __pbn__Proto;

        [global::ProtoBuf.ProtoMember(2, Name = @"user")]
        [global::System.ComponentModel.DefaultValue("")]
        public string User
        {
            get { return __pbn__User ?? ""; }
            set { __pbn__User = value; }
        }
        public bool ShouldSerializeUser() => __pbn__User != null;
        public void ResetUser() => __pbn__User = null;
        private string __pbn__User;

        [global::ProtoBuf.ProtoMember(3, Name = @"host")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Host
        {
            get { return __pbn__Host ?? ""; }
            set { __pbn__Host = value; }
        }
        public bool ShouldSerializeHost() => __pbn__Host != null;
        public void ResetHost() => __pbn__Host = null;
        private string __pbn__Host;

        [global::ProtoBuf.ProtoMember(4, Name = @"port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Port
        {
            get { return __pbn__Port ?? ""; }
            set { __pbn__Port = value; }
        }
        public bool ShouldSerializePort() => __pbn__Port != null;
        public void ResetPort() => __pbn__Port = null;
        private string __pbn__Port;

        [global::ProtoBuf.ProtoMember(5, Name = @"path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Path
        {
            get { return __pbn__Path ?? ""; }
            set { __pbn__Path = value; }
        }
        public bool ShouldSerializePath() => __pbn__Path != null;
        public void ResetPath() => __pbn__Path = null;
        private string __pbn__Path;

        [global::ProtoBuf.ProtoMember(6, Name = @"index")]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint Index
        {
            get { return __pbn__Index ?? 0; }
            set { __pbn__Index = value; }
        }
        public bool ShouldSerializeIndex() => __pbn__Index != null;
        public void ResetIndex() => __pbn__Index = null;
        private uint? __pbn__Index;

    }
}