using ProtoBuf;

namespace Trezor
{
    public class NEMTransactionCommon
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"network")]
        public uint Network
        {
            get => __pbn__Network.GetValueOrDefault();
            set => __pbn__Network = value;
        }
        public bool ShouldSerializeNetwork() => __pbn__Network != null;
        public void ResetNetwork() => __pbn__Network = null;
        private uint? __pbn__Network;

        [ProtoMember(3, Name = @"timestamp")]
        public uint Timestamp
        {
            get => __pbn__Timestamp.GetValueOrDefault();
            set => __pbn__Timestamp = value;
        }
        public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
        public void ResetTimestamp() => __pbn__Timestamp = null;
        private uint? __pbn__Timestamp;

        [ProtoMember(4, Name = @"fee")]
        public ulong Fee
        {
            get => __pbn__Fee.GetValueOrDefault();
            set => __pbn__Fee = value;
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

        [ProtoMember(5, Name = @"deadline")]
        public uint Deadline
        {
            get => __pbn__Deadline.GetValueOrDefault();
            set => __pbn__Deadline = value;
        }
        public bool ShouldSerializeDeadline() => __pbn__Deadline != null;
        public void ResetDeadline() => __pbn__Deadline = null;
        private uint? __pbn__Deadline;

        [ProtoMember(6, Name = @"signer")]
        public byte[] Signer { get; set; }

        public bool ShouldSerializeSigner() => Signer != null;
        public void ResetSigner() => Signer = null;
    }
}