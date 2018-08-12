using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EnumDescriptorProto
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

        [ProtoMember(2, Name = @"value")]
        public List<EnumValueDescriptorProto> Values { get; } = new List<EnumValueDescriptorProto>();

        [ProtoMember(3, Name = @"options")]
        public EnumOptions Options { get; set; }

        [ProtoMember(4, Name = @"reserved_range")]
        public List<EnumReservedRange> ReservedRanges { get; } = new List<EnumReservedRange>();

        [ProtoMember(5, Name = @"reserved_name")]
        public List<string> ReservedNames { get; } = new List<string>();

        [ProtoContract]
        public class EnumReservedRange
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