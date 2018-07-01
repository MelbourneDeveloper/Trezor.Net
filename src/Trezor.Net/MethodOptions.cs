using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class MethodOptions : IExtensible
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

        [ProtoMember(34)]
        [DefaultValue(IdempotencyLevel.IdempotencyUnknown)]
        public IdempotencyLevel idempotency_level
        {
            get => __pbn__idempotency_level ?? IdempotencyLevel.IdempotencyUnknown;
            set => __pbn__idempotency_level = value;
        }
        public bool ShouldSerializeidempotency_level() => __pbn__idempotency_level != null;
        public void Resetidempotency_level() => __pbn__idempotency_level = null;
        private IdempotencyLevel? __pbn__idempotency_level;

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

        [ProtoContract]
        public enum IdempotencyLevel
        {
            [ProtoEnum(Name = @"IDEMPOTENCY_UNKNOWN")]
            IdempotencyUnknown = 0,
            [ProtoEnum(Name = @"NO_SIDE_EFFECTS")]
            NoSideEffects = 1,
            [ProtoEnum(Name = @"IDEMPOTENT")]
            Idempotent = 2
        }

    }
}