using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class FileDescriptorProto
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

        [ProtoMember(2, Name = @"package")]
        [DefaultValue("")]
        public string Package
        {
            get => __pbn__Package ?? "";
            set => __pbn__Package = value;
        }
        public bool ShouldSerializePackage() => __pbn__Package != null;
        public void ResetPackage() => __pbn__Package = null;
        private string __pbn__Package;

        [ProtoMember(3, Name = @"dependency")]
        public List<string> Dependencies { get; } = new List<string>();

        [ProtoMember(10, Name = @"public_dependency")]
        public int[] PublicDependencies { get; set; }

        [ProtoMember(11, Name = @"weak_dependency")]
        public int[] WeakDependencies { get; set; }

        [ProtoMember(4, Name = @"message_type")]
        public List<DescriptorProto> MessageTypes { get; } = new List<DescriptorProto>();

        [ProtoMember(5, Name = @"enum_type")]
        public List<EnumDescriptorProto> EnumTypes { get; } = new List<EnumDescriptorProto>();

        [ProtoMember(6, Name = @"service")]
        public List<ServiceDescriptorProto> Services { get; } = new List<ServiceDescriptorProto>();

        [ProtoMember(7, Name = @"extension")]
        public List<FieldDescriptorProto> Extensions { get; } = new List<FieldDescriptorProto>();

        [ProtoMember(8, Name = @"options")]
        public FileOptions Options { get; set; }

        [ProtoMember(9, Name = @"source_code_info")]
        public SourceCodeInfo SourceCodeInfo { get; set; }

        [ProtoMember(12, Name = @"syntax")]
        [DefaultValue("")]
        public string Syntax
        {
            get => __pbn__Syntax ?? "";
            set => __pbn__Syntax = value;
        }
        public bool ShouldSerializeSyntax() => __pbn__Syntax != null;
        public void ResetSyntax() => __pbn__Syntax = null;
        private string __pbn__Syntax;

    }
}