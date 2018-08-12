using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class ServiceOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(33, Name = @"deprecated")]
        [DefaultValue(false)]
        public bool Deprecated
        {
            get => __pbn__Deprecated ?? false;
            set => __pbn__Deprecated = value;
        }
        public bool ShouldSerializeDeprecated() => __pbn__Deprecated != null;
        public void ResetDeprecated() => __pbn__Deprecated = null;
        private bool? __pbn__Deprecated;

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

    }
}