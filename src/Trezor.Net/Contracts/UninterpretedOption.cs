using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class UninterpretedOption
    {
        [ProtoMember(2, Name = @"name")]
        public List<NamePart> Names { get; } = new List<NamePart>();

        [ProtoMember(3, Name = @"identifier_value")]
        [DefaultValue("")]
        public string IdentifierValue
        {
            get => __pbn__IdentifierValue ?? "";
            set => __pbn__IdentifierValue = value;
        }
        public bool ShouldSerializeIdentifierValue() => __pbn__IdentifierValue != null;
        public void ResetIdentifierValue() => __pbn__IdentifierValue = null;
        private string __pbn__IdentifierValue;

        [ProtoMember(4, Name = @"positive_int_value")]
        public ulong PositiveIntValue
        {
            get => __pbn__PositiveIntValue.GetValueOrDefault();
            set => __pbn__PositiveIntValue = value;
        }
        public bool ShouldSerializePositiveIntValue() => __pbn__PositiveIntValue != null;
        public void ResetPositiveIntValue() => __pbn__PositiveIntValue = null;
        private ulong? __pbn__PositiveIntValue;

        [ProtoMember(5, Name = @"negative_int_value")]
        public long NegativeIntValue
        {
            get => __pbn__NegativeIntValue.GetValueOrDefault();
            set => __pbn__NegativeIntValue = value;
        }
        public bool ShouldSerializeNegativeIntValue() => __pbn__NegativeIntValue != null;
        public void ResetNegativeIntValue() => __pbn__NegativeIntValue = null;
        private long? __pbn__NegativeIntValue;

        [ProtoMember(6, Name = @"double_value")]
        public double DoubleValue
        {
            get => __pbn__DoubleValue.GetValueOrDefault();
            set => __pbn__DoubleValue = value;
        }
        public bool ShouldSerializeDoubleValue() => __pbn__DoubleValue != null;
        public void ResetDoubleValue() => __pbn__DoubleValue = null;
        private double? __pbn__DoubleValue;

        [ProtoMember(7, Name = @"string_value")]
        public byte[] StringValue { get; set; }

        public bool ShouldSerializeStringValue() => StringValue != null;
        public void ResetStringValue() => StringValue = null;

        [ProtoMember(8, Name = @"aggregate_value")]
        [DefaultValue("")]
        public string AggregateValue
        {
            get => __pbn__AggregateValue ?? "";
            set => __pbn__AggregateValue = value;
        }
        public bool ShouldSerializeAggregateValue() => __pbn__AggregateValue != null;
        public void ResetAggregateValue() => __pbn__AggregateValue = null;
        private string __pbn__AggregateValue;

        [ProtoContract]
        public class NamePart
        {
            [ProtoMember(1, IsRequired = true)]
            public string name_part { get; set; }

            [ProtoMember(2, Name = @"is_extension", IsRequired = true)]
            public bool IsExtension { get; set; }

        }

    }
}