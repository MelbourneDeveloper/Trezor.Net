using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class Entropy
    {
        [ProtoMember(1, IsRequired = true)]
        public byte[] entropy { get; set; }

    }
}