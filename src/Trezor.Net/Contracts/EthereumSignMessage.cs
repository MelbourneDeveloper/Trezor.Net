using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class EthereumSignMessage
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"message", IsRequired = true)]
        public byte[] Message { get; set; }

    }
}