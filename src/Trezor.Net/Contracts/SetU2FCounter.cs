using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class SetU2FCounter
    {
        [ProtoMember(1, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get => __pbn__U2fCounter.GetValueOrDefault();
            set => __pbn__U2fCounter = value;
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

    }
}