using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class TxAck
    {
        [ProtoMember(1, Name = @"tx")]
        public TransactionType Tx { get; set; }

    }
}