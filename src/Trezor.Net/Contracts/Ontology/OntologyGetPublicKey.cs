namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologyGetPublicKey : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"show_display")]
        public bool ShowDisplay
        {
            get => __pbn__ShowDisplay.GetValueOrDefault();
            set => __pbn__ShowDisplay = value;
        }
        public bool ShouldSerializeShowDisplay()
        {
            return __pbn__ShowDisplay != null;
        }

        public void ResetShowDisplay()
        {
            __pbn__ShowDisplay = null;
        }

        private bool? __pbn__ShowDisplay;

    }
}