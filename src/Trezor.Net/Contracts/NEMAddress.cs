using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMAddress
    {
        [ProtoMember(1, Name = @"address", IsRequired = true)]
        public string Address { get; set; }

    }
}