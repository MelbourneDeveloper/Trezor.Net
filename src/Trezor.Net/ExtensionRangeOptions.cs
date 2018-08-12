using System.Collections.Generic;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class ExtensionRangeOptions : IExtensible
    {
        private IExtension __pbn__extensionData;
        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
            => Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoMember(999, Name = @"uninterpreted_option")]
        public List<UninterpretedOption> UninterpretedOptions { get; } = new List<UninterpretedOption>();

    }
}