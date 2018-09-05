using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMMosaicCreation
    {
        [ProtoMember(1, Name = @"definition")]
        public NEMMosaicDefinition Definition { get; set; }

        [ProtoMember(2, Name = @"sink")]
        [DefaultValue("")]
        public string Sink
        {
            get => __pbn__Sink ?? "";
            set => __pbn__Sink = value;
        }
        public bool ShouldSerializeSink() => __pbn__Sink != null;
        public void ResetSink() => __pbn__Sink = null;
        private string __pbn__Sink;

        [ProtoMember(3, Name = @"fee")]
        public ulong Fee
        {
            get => __pbn__Fee.GetValueOrDefault();
            set => __pbn__Fee = value;
        }
        public bool ShouldSerializeFee() => __pbn__Fee != null;
        public void ResetFee() => __pbn__Fee = null;
        private ulong? __pbn__Fee;

    }
}