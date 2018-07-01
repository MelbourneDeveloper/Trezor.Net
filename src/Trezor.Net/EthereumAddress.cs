using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class EthereumAddress
    {
        [ProtoMember(1, Name = @"address", IsRequired = true)]
        public byte[] Address { get; set; }

    }
}