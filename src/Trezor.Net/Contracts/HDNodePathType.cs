using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class HDNodePathType
    {
        [ProtoMember(1, Name = @"node", IsRequired = true)]
        public HDNodeType Node { get; set; }

        [ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

    }
}