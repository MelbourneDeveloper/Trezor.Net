namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class SetU2FCounter : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"u2f_counter")]
        public uint U2fCounter
        {
            get { return __pbn__U2fCounter.GetValueOrDefault(); }
            set { __pbn__U2fCounter = value; }
        }
        public bool ShouldSerializeU2fCounter() => __pbn__U2fCounter != null;
        public void ResetU2fCounter() => __pbn__U2fCounter = null;
        private uint? __pbn__U2fCounter;

    }
}