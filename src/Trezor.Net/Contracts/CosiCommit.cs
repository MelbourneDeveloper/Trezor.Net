using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class CosiCommit
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"data")]
        public byte[] Data { get; set; }

        public bool ShouldSerializeData() => Data != null;
        public void ResetData() => Data = null;
    }
}