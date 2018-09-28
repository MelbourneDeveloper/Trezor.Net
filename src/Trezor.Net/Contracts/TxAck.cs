using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class TxAck
    {
        [ProtoMember(1, Name = @"tx")]
        public TransactionType Tx { get; set; }

    }
}