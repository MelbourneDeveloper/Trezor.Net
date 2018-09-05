using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class FieldOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(1, Name = @"ctype")]
        [DefaultValue(CType.String)]
        public CType Ctype
        {
            get => __pbn__Ctype ?? CType.String;
            set => __pbn__Ctype = value;
        }
        public bool ShouldSerializeCtype() => __pbn__Ctype != null;
        public void ResetCtype() => __pbn__Ctype = null;
        private CType? __pbn__Ctype;

        [ProtoMember(2, Name = @"packed")]
        public bool Packed
        {
            get => __pbn__Packed.GetValueOrDefault();
            set => __pbn__Packed = value;
        }
        public bool ShouldSerializePacked() => __pbn__Packed != null;
        public void ResetPacked() => __pbn__Packed = null;
        private bool? __pbn__Packed;

        [ProtoMember(6, Name = @"jstype")]
        [DefaultValue(JSType.JsNormal)]
        public JSType Jstype
        {
            get => __pbn__Jstype ?? JSType.JsNormal;
            set => __pbn__Jstype = value;
        }
        public bool ShouldSerializeJstype() => __pbn__Jstype != null;
        public void ResetJstype() => __pbn__Jstype = null;
        private JSType? __pbn__Jstype;

        [ProtoMember(5, Name = @"lazy")]
        [DefaultValue(false)]
        public bool Lazy
        {
            get => __pbn__Lazy ?? false;
            set => __pbn__Lazy = value;
        }
        public bool ShouldSerializeLazy() => __pbn__Lazy != null;
        public void ResetLazy() => __pbn__Lazy = null;
        private bool? __pbn__Lazy;

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

        [ProtoMember(10, Name = @"weak")]
        [DefaultValue(false)]
        public bool Weak
        {
            get => __pbn__Weak ?? false;
            set => __pbn__Weak = value;
        }
        public bool ShouldSerializeWeak() => __pbn__Weak != null;
        public void ResetWeak() => __pbn__Weak = null;
        private bool? __pbn__Weak;

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

        [ProtoContract]
        public enum CType
        {
            [ProtoEnum(Name = @"STRING")]
            String = 0,
            [ProtoEnum(Name = @"CORD")]
            Cord = 1,
            [ProtoEnum(Name = @"STRING_PIECE")]
            StringPiece = 2
        }

        [ProtoContract]
        public enum JSType
        {
            [ProtoEnum(Name = @"JS_NORMAL")]
            JsNormal = 0,
            [ProtoEnum(Name = @"JS_STRING")]
            JsString = 1,
            [ProtoEnum(Name = @"JS_NUMBER")]
            JsNumber = 2
        }

    }
}