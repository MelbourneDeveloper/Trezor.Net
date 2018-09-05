using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class MethodDescriptorProto
    {
        [ProtoMember(1, Name = @"name")]
        [DefaultValue("")]
        public string Name
        {
            get => __pbn__Name ?? "";
            set => __pbn__Name = value;
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [ProtoMember(2, Name = @"input_type")]
        [DefaultValue("")]
        public string InputType
        {
            get => __pbn__InputType ?? "";
            set => __pbn__InputType = value;
        }
        public bool ShouldSerializeInputType() => __pbn__InputType != null;
        public void ResetInputType() => __pbn__InputType = null;
        private string __pbn__InputType;

        [ProtoMember(3, Name = @"output_type")]
        [DefaultValue("")]
        public string OutputType
        {
            get => __pbn__OutputType ?? "";
            set => __pbn__OutputType = value;
        }
        public bool ShouldSerializeOutputType() => __pbn__OutputType != null;
        public void ResetOutputType() => __pbn__OutputType = null;
        private string __pbn__OutputType;

        [ProtoMember(4, Name = @"options")]
        public MethodOptions Options { get; set; }

        [ProtoMember(5, Name = @"client_streaming")]
        [DefaultValue(false)]
        public bool ClientStreaming
        {
            get => __pbn__ClientStreaming ?? false;
            set => __pbn__ClientStreaming = value;
        }
        public bool ShouldSerializeClientStreaming() => __pbn__ClientStreaming != null;
        public void ResetClientStreaming() => __pbn__ClientStreaming = null;
        private bool? __pbn__ClientStreaming;

        [ProtoMember(6, Name = @"server_streaming")]
        [DefaultValue(false)]
        public bool ServerStreaming
        {
            get => __pbn__ServerStreaming ?? false;
            set => __pbn__ServerStreaming = value;
        }
        public bool ShouldSerializeServerStreaming() => __pbn__ServerStreaming != null;
        public void ResetServerStreaming() => __pbn__ServerStreaming = null;
        private bool? __pbn__ServerStreaming;

    }
}