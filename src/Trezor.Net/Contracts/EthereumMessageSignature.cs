using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class EthereumMessageSignature
    {
        [ProtoMember(1, Name = @"address")]
        public byte[] Address { get; set; }

        public bool ShouldSerializeAddress() => Address != null;
        public void ResetAddress() => Address = null;

        [ProtoMember(2, Name = @"signature")]
        public byte[] Signature { get; set; }

        public bool ShouldSerializeSignature() => Signature != null;
        public void ResetSignature() => Signature = null;
    }
}