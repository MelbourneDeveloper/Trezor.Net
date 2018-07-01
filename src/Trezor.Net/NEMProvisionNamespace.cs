using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class NEMProvisionNamespace
    {
        [ProtoMember(1, Name = @"namespace")]
        [DefaultValue("")]
        public string Namespace
        {
            get => __pbn__Namespace ?? "";
            set => __pbn__Namespace = value;
        }
        public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
        public void ResetNamespace() => __pbn__Namespace = null;
        private string __pbn__Namespace;

        [ProtoMember(2, Name = @"parent")]
        [DefaultValue("")]
        public string Parent
        {
            get => __pbn__Parent ?? "";
            set => __pbn__Parent = value;
        }
        public bool ShouldSerializeParent() => __pbn__Parent != null;
        public void ResetParent() => __pbn__Parent = null;
        private string __pbn__Parent;

        [ProtoMember(3, Name = @"sink")]
        [DefaultValue("")]
        public string Sink
        {
            get => __pbn__Sink ?? "";
            set => __pbn__Sink = value;
        }
        public bool ShouldSerializeSink() => __pbn__Sink != null;
        public void ResetSink() => __pbn__Sink = null;
        private string __pbn__Sink;

        [ProtoMember(4, Name = @"fee")]
        public ulong Fee
        {
            get => __pbn__Fee.GetValueOrDefault();
            set => __pbn__Fee = value;
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

    }
}