namespace Trezor.Net.Contracts.Debug
{
    [ProtoBuf.ProtoContract()]
    public class DebugLinkLog : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"level")]
        public uint Level
        {
            get { return __pbn__Level.GetValueOrDefault(); }
            set { __pbn__Level = value; }
        }
        public bool ShouldSerializeLevel() => __pbn__Level != null;
        public void ResetLevel() => __pbn__Level = null;
        private uint? __pbn__Level;

        [ProtoBuf.ProtoMember(2, Name = @"bucket")]
        [System.ComponentModel.DefaultValue("")]
        public string Bucket
        {
            get { return __pbn__Bucket ?? ""; }
            set { __pbn__Bucket = value; }
        }
        public bool ShouldSerializeBucket() => __pbn__Bucket != null;
        public void ResetBucket() => __pbn__Bucket = null;
        private string __pbn__Bucket;

        [ProtoBuf.ProtoMember(3, Name = @"text")]
        [System.ComponentModel.DefaultValue("")]
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