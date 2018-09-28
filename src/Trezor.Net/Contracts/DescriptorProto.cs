using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DescriptorProto
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

        [ProtoMember(2, Name = @"field")]
        public List<FieldDescriptorProto> Fields { get; } = new List<FieldDescriptorProto>();

        [ProtoMember(6, Name = @"extension")]
        public List<FieldDescriptorProto> Extensions { get; } = new List<FieldDescriptorProto>();

        [ProtoMember(3, Name = @"nested_type")]
        public List<DescriptorProto> NestedTypes { get; } = new List<DescriptorProto>();

        [ProtoMember(4, Name = @"enum_type")]
        public List<EnumDescriptorProto> EnumTypes { get; } = new List<EnumDescriptorProto>();

        [ProtoMember(5, Name = @"extension_range")]
        public List<ExtensionRange> ExtensionRanges { get; } = new List<ExtensionRange>();

        [ProtoMember(8, Name = @"oneof_decl")]
        public List<OneofDescriptorProto> OneofDecls { get; } = new List<OneofDescriptorProto>();

        [ProtoMember(7, Name = @"options")]
        public MessageOptions Options { get; set; }

        [ProtoMember(9, Name = @"reserved_range")]
        public List<ReservedRange> ReservedRanges { get; } = new List<ReservedRange>();

        [ProtoMember(10, Name = @"reserved_name")]
        public List<string> ReservedNames { get; } = new List<string>();

        [ProtoContract]
        public class ExtensionRange
        {
            [ProtoMember(1, Name = @"start")]
            public int Start
            {
                get => __pbn__Start.GetValueOrDefault();
                set => __pbn__Start = value;
            }
            public bool ShouldSerializeStart() => __pbn__Start != null;
            public void ResetStart() => __pbn__Start = null;
            private int? __pbn__Start;

            [ProtoMember(2, Name = @"end")]
            public int End
            {
                get => __pbn__End.GetValueOrDefault();
                set => __pbn__End = value;
            }
            public bool ShouldSerializeEnd() => __pbn__End != null;
            public void ResetEnd() => __pbn__End = null;
            private int? __pbn__End;

            [ProtoMember(3, Name = @"options")]
            public ExtensionRangeOptions Options { get; set; }

        }

        [ProtoContract]
        public class ReservedRange
        {
            [ProtoMember(1, Name = @"start")]
            public int Start
            {
                get => __pbn__Start.GetValueOrDefault();
                set => __pbn__Start = value;
            }
            public bool ShouldSerializeStart() => __pbn__Start != null;
            public void ResetStart() => __pbn__Start = null;
            private int? __pbn__Start;

            [ProtoMember(2, Name = @"end")]
            public int End
            {
                get => __pbn__End.GetValueOrDefault();
                set => __pbn__End = value;
            }
            public bool ShouldSerializeEnd() => __pbn__End != null;
            public void ResetEnd() => __pbn__End = null;
            private int? __pbn__End;

        }

    }
}