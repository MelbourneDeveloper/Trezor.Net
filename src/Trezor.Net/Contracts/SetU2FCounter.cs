namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class SetU2FCounter : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"u2f_counter")]
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