using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class FieldDescriptorProto
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

        [ProtoMember(3, Name = @"number")]
        public int Number
        {
            get => __pbn__Number.GetValueOrDefault();
            set => __pbn__Number = value;
        }
        public bool ShouldSerializeNumber() => __pbn__Number != null;
        public void ResetNumber() => __pbn__Number = null;
        private int? __pbn__Number;

        [ProtoMember(4)]
        [DefaultValue(Label.LabelOptional)]
        public Label label
        {
            get => __pbn__label ?? Label.LabelOptional;
            set => __pbn__label = value;
        }
        public bool ShouldSerializelabel() => __pbn__label != null;
        public void Resetlabel() => __pbn__label = null;
        private Label? __pbn__label;

        [ProtoMember(5)]
        [DefaultValue(Type.TypeDouble)]
        public Type type
        {
            get => __pbn__type ?? Type.TypeDouble;
            set => __pbn__type = value;
        }
        public bool ShouldSerializetype() => __pbn__type != null;
        public void Resettype() => __pbn__type = null;
        private Type? __pbn__type;

        [ProtoMember(6, Name = @"type_name")]
        [DefaultValue("")]
        public string TypeName
        {
            get => __pbn__TypeName ?? "";
            set => __pbn__TypeName = value;
        }
        public bool ShouldSerializeTypeName() => __pbn__TypeName != null;
        public void ResetTypeName() => __pbn__TypeName = null;
        private string __pbn__TypeName;

        [ProtoMember(2, Name = @"extendee")]
        [DefaultValue("")]
        public string Extendee
        {
            get => __pbn__Extendee ?? "";
            set => __pbn__Extendee = value;
        }
        public bool ShouldSerializeExtendee() => __pbn__Extendee != null;
        public void ResetExtendee() => __pbn__Extendee = null;
        private string __pbn__Extendee;

        [ProtoMember(7, Name = @"default_value")]
        [DefaultValue("")]
        public string DefaultValue
        {
            get => __pbn__DefaultValue ?? "";
            set => __pbn__DefaultValue = value;
        }
        public bool ShouldSerializeDefaultValue() => __pbn__DefaultValue != null;
        public void ResetDefaultValue() => __pbn__DefaultValue = null;
        private string __pbn__DefaultValue;

        [ProtoMember(9, Name = @"oneof_index")]
        public int OneofIndex
        {
            get => __pbn__OneofIndex.GetValueOrDefault();
            set => __pbn__OneofIndex = value;
        }
        public bool ShouldSerializeOneofIndex() => __pbn__OneofIndex != null;
        public void ResetOneofIndex() => __pbn__OneofIndex = null;
        private int? __pbn__OneofIndex;

        [ProtoMember(10, Name = @"json_name")]
        [DefaultValue("")]
        public string JsonName
        {
            get => __pbn__JsonName ?? "";
            set => __pbn__JsonName = value;
        }
        public bool ShouldSerializeJsonName() => __pbn__JsonName != null;
        public void ResetJsonName() => __pbn__JsonName = null;
        private string __pbn__JsonName;

        [ProtoMember(8, Name = @"options")]
        public FieldOptions Options { get; set; }

        [ProtoContract]
        public enum Type
        {
            [ProtoEnum(Name = @"TYPE_DOUBLE")]
            TypeDouble = 1,
            [ProtoEnum(Name = @"TYPE_FLOAT")]
            TypeFloat = 2,
            [ProtoEnum(Name = @"TYPE_INT64")]
            TypeInt64 = 3,
            [ProtoEnum(Name = @"TYPE_UINT64")]
            TypeUint64 = 4,
            [ProtoEnum(Name = @"TYPE_INT32")]
            TypeInt32 = 5,
            [ProtoEnum(Name = @"TYPE_FIXED64")]
            TypeFixed64 = 6,
            [ProtoEnum(Name = @"TYPE_FIXED32")]
            TypeFixed32 = 7,
            [ProtoEnum(Name = @"TYPE_BOOL")]
            TypeBool = 8,
            [ProtoEnum(Name = @"TYPE_STRING")]
            TypeString = 9,
            [ProtoEnum(Name = @"TYPE_GROUP")]
            TypeGroup = 10,
            [ProtoEnum(Name = @"TYPE_MESSAGE")]
            TypeMessage = 11,
            [ProtoEnum(Name = @"TYPE_BYTES")]
            TypeBytes = 12,
            [ProtoEnum(Name = @"TYPE_UINT32")]
            TypeUint32 = 13,
            [ProtoEnum(Name = @"TYPE_ENUM")]
            TypeEnum = 14,
            [ProtoEnum(Name = @"TYPE_SFIXED32")]
            TypeSfixed32 = 15,
            [ProtoEnum(Name = @"TYPE_SFIXED64")]
            TypeSfixed64 = 16,
            [ProtoEnum(Name = @"TYPE_SINT32")]
            TypeSint32 = 17,
            [ProtoEnum(Name = @"TYPE_SINT64")]
            TypeSint64 = 18
        }

        [ProtoContract]
        public enum Label
        {
            [ProtoEnum(Name = @"LABEL_OPTIONAL")]
            LabelOptional = 1,
            [ProtoEnum(Name = @"LABEL_REQUIRED")]
            LabelRequired = 2,
            [ProtoEnum(Name = @"LABEL_REPEATED")]
            LabelRepeated = 3
        }

    }
}