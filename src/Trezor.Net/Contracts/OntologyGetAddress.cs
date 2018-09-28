namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologyGetAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"show_display")]
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