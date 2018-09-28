namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class PassphraseRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"on_device")]
        public bool OnDevice
        {
            get => __pbn__OnDevice.GetValueOrDefault();
            set => __pbn__OnDevice = value;
        }
        public bool ShouldSerializeOnDevice() => __pbn__OnDevice != null;
        public void ResetOnDevice() => __pbn__OnDevice = null;
        private bool? __pbn__OnDevice;

    }
}