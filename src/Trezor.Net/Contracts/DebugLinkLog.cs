using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DebugLinkLog
    {
        [ProtoMember(1, Name = @"level")]
        public uint Level
        {
            get => __pbn__Level.GetValueOrDefault();
            set => __pbn__Level = value;
        }
        public bool ShouldSerializeLevel() => __pbn__Level != null;
        public void ResetLevel() => __pbn__Level = null;
        private uint? __pbn__Level;

        [ProtoMember(2, Name = @"bucket")]
        [DefaultValue("")]
        public string Bucket
        {
            get => __pbn__Bucket ?? "";
            set => __pbn__Bucket = value;
        }
        public bool ShouldSerializeBucket() => __pbn__Bucket != null;
        public void ResetBucket() => __pbn__Bucket = null;
        private string __pbn__Bucket;

        [ProtoMember(3, Name = @"text")]
        [DefaultValue("")]
        public string Text
        {
            get => __pbn__Text ?? "";
            set => __pbn__Text = value;
        }
        public bool ShouldSerializeText() => __pbn__Text != null;
        public void ResetText() => __pbn__Text = null;
        private string __pbn__Text;

    }
}