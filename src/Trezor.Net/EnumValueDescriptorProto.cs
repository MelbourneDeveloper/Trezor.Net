using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EnumValueDescriptorProto
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

        [ProtoMember(2, Name = @"number")]
        public int Number
        {
            get => __pbn__Number.GetValueOrDefault();
            set => __pbn__Number = value;
        }
        public bool ShouldSerializeNumber() => __pbn__Number != null;
        public void ResetNumber() => __pbn__Number = null;
        private int? __pbn__Number;

        [ProtoMember(3, Name = @"options")]
        public EnumValueOptions Options { get; set; }

    }
}