using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class MessageOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(1, Name = @"message_set_wire_format")]
        [DefaultValue(false)]
        public bool MessageSetWireFormat
        {
            get => __pbn__MessageSetWireFormat ?? false;
            set => __pbn__MessageSetWireFormat = value;
        }
        public bool ShouldSerializeMessageSetWireFormat() => __pbn__MessageSetWireFormat != null;
        public void ResetMessageSetWireFormat() => __pbn__MessageSetWireFormat = null;
        private bool? __pbn__MessageSetWireFormat;

        [ProtoMember(2, Name = @"no_standard_descriptor_accessor")]
        [DefaultValue(false)]
        public bool NoStandardDescriptorAccessor
        {
            get => __pbn__NoStandardDescriptorAccessor ?? false;
            set => __pbn__NoStandardDescriptorAccessor = value;
        }
        public bool ShouldSerializeNoStandardDescriptorAccessor() => __pbn__NoStandardDescriptorAccessor != null;
        public void ResetNoStandardDescriptorAccessor() => __pbn__NoStandardDescriptorAccessor = null;
        private bool? __pbn__NoStandardDescriptorAccessor;

        [ProtoMember(3, Name = @"deprecated")]
        [DefaultValue(false)]
        public bool Deprecated
        {
            get => __pbn__Deprecated ?? false;
            set => __pbn__Deprecated = value;
        }
        public bool ShouldSerializeDeprecated() => __pbn__Deprecated != null;
        public void ResetDeprecated() => __pbn__Deprecated = null;
        private bool? __pbn__Deprecated;

        [ProtoMember(7, Name = @"map_entry")]
        public bool MapEntry
        {
            get => __pbn__MapEntry.GetValueOrDefault();
            set => __pbn__MapEntry = value;
        }
        public bool ShouldSerializeMapEntry() => __pbn__MapEntry != null;
        public void ResetMapEntry() => __pbn__MapEntry = null;
        private bool? __pbn__MapEntry;

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

    }
}