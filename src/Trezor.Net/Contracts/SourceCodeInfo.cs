using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class SourceCodeInfo
    {
        [ProtoMember(1, Name = @"location")]
        public List<Location> Locations { get; } = new List<Location>();

        [ProtoContract]
        public class Location
        {
            [ProtoMember(1, Name = @"path", IsPacked = true)]
            public int[] Paths { get; set; }

            [ProtoMember(2, Name = @"span", IsPacked = true)]
            public int[] Spans { get; set; }

            [ProtoMember(3, Name = @"leading_comments")]
            [DefaultValue("")]
            public string LeadingComments
            {
                get => __pbn__LeadingComments ?? "";
                set => __pbn__LeadingComments = value;
            }
            public bool ShouldSerializeLeadingComments() => __pbn__LeadingComments != null;
            public void ResetLeadingComments() => __pbn__LeadingComments = null;
            private string __pbn__LeadingComments;

            [ProtoMember(4, Name = @"trailing_comments")]
            [DefaultValue("")]
            public string TrailingComments
            {
                get => __pbn__TrailingComments ?? "";
                set => __pbn__TrailingComments = value;
            }
            public bool ShouldSerializeTrailingComments() => __pbn__TrailingComments != null;
            public void ResetTrailingComments() => __pbn__TrailingComments = null;
            private string __pbn__TrailingComments;

            [ProtoMember(6, Name = @"leading_detached_comments")]
            public List<string> LeadingDetachedComments { get; } = new List<string>();

        }

    }
}