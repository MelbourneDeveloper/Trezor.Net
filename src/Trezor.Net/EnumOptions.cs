using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class EnumOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(2, Name = @"allow_alias")]
        public bool AllowAlias
        {
            get => __pbn__AllowAlias.GetValueOrDefault();
            set => __pbn__AllowAlias = value;
        }
        public bool ShouldSerializeAllowAlias() => __pbn__AllowAlias != null;
        public void ResetAllowAlias() => __pbn__AllowAlias = null;
        private bool? __pbn__AllowAlias;

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

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

    }
}