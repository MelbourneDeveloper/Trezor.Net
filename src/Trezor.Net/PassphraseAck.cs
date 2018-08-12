using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class PassphraseAck
    {
        [ProtoMember(1, Name = @"passphrase", IsRequired = true)]
        public string Passphrase { get; set; }

    }
}