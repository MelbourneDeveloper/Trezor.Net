using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class FirmwareUpload
    {
        [ProtoMember(1, Name = @"payload", IsRequired = true)]
        public byte[] Payload { get; set; }

        [ProtoMember(2, Name = @"hash")]
        public byte[] Hash { get; set; }

        public bool ShouldSerializeHash() => Hash != null;
        public void ResetHash() => Hash = null;
    }
}