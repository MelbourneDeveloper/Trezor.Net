using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class WordAck
    {
        [ProtoMember(1, Name = @"word", IsRequired = true)]
        public string Word { get; set; }

    }
}