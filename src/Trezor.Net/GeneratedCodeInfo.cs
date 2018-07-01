using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class GeneratedCodeInfo
    {
        [ProtoMember(1, Name = @"annotation")]
        public List<Annotation> Annotations { get; } = new List<Annotation>();

        [ProtoContract]
        public class Annotation
        {
            [ProtoMember(1, Name = @"path", IsPacked = true)]
            public int[] Paths { get; set; }

            [ProtoMember(2, Name = @"source_file")]
            [DefaultValue("")]
            public string SourceFile
            {
                get => __pbn__SourceFile ?? "";
                set => __pbn__SourceFile = value;
            }
            public bool ShouldSerializeSourceFile() => __pbn__SourceFile != null;
            public void ResetSourceFile() => __pbn__SourceFile = null;
            private string __pbn__SourceFile;

            [ProtoMember(3, Name = @"begin")]
            public int Begin
            {
                get => __pbn__Begin.GetValueOrDefault();
                set => __pbn__Begin = value;
            }
            public bool ShouldSerializeBegin() => __pbn__Begin != null;
            public void ResetBegin() => __pbn__Begin = null;
            private int? __pbn__Begin;

            [ProtoMember(4, Name = @"end")]
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