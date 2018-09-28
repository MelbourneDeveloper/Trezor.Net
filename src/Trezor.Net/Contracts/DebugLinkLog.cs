namespace Trezor.Net.Contracts.Debug
{
    [global::ProtoBuf.ProtoContract()]
    public class DebugLinkLog : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"level")]
        public uint Level
        {
            get { return __pbn__Level.GetValueOrDefault(); }
            set { __pbn__Level = value; }
        }
        public bool ShouldSerializeLevel() => __pbn__Level != null;
        public void ResetLevel() => __pbn__Level = null;
        private uint? __pbn__Level;

        [global::ProtoBuf.ProtoMember(2, Name = @"bucket")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Bucket
        {
            get { return __pbn__Bucket ?? ""; }
            set { __pbn__Bucket = value; }
        }
        public bool ShouldSerializeBucket() => __pbn__Bucket != null;
        public void ResetBucket() => __pbn__Bucket = null;
        private string __pbn__Bucket;

        [global::ProtoBuf.ProtoMember(3, Name = @"text")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Text
        {
            get { return __pbn__Text ?? ""; }
            set { __pbn__Text = value; }
        }
        public bool ShouldSerializeText() => __pbn__Text != null;
        public void ResetText() => __pbn__Text = null;
        private string __pbn__Text;

    }
}