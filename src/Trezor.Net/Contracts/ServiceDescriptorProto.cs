using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class ServiceDescriptorProto
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

        [ProtoMember(2, Name = @"method")]
        public List<MethodDescriptorProto> Methods { get; } = new List<MethodDescriptorProto>();

        [ProtoMember(3, Name = @"options")]
        public ServiceOptions Options { get; set; }

    }
}