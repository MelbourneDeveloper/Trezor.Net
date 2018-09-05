using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class DebugLinkDecision
    {
        [ProtoMember(1, Name = @"yes_no", IsRequired = true)]
        public bool YesNo { get; set; }

    }
}