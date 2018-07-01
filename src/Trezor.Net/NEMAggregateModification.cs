using System.Collections.Generic;
using ProtoBuf;

namespace Trezor
{
    public class NEMAggregateModification
    {
        [ProtoMember(1, Name = @"modifications")]
        public List<NEMCosignatoryModification> Modifications { get; } = new List<NEMCosignatoryModification>();

        [ProtoMember(2, Name = @"relative_change", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public int RelativeChange
        {
            get => __pbn__RelativeChange.GetValueOrDefault();
            set => __pbn__RelativeChange = value;
        }
        public bool ShouldSerializeRelativeChange() => __pbn__RelativeChange != null;
        public void ResetRelativeChange() => __pbn__RelativeChange = null;
        private int? __pbn__RelativeChange;

    }
}