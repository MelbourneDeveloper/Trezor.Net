namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class PassphraseRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"on_device")]
        public bool OnDevice
        {
            get { return __pbn__OnDevice.GetValueOrDefault(); }
            set { __pbn__OnDevice = value; }
        }
        public bool ShouldSerializeOnDevice() => __pbn__OnDevice != null;
        public void ResetOnDevice() => __pbn__OnDevice = null;
        private bool? __pbn__OnDevice;

    }
}