namespace Trezor.Net.Contracts.Ontology
{
    [ProtoBuf.ProtoContract()]
    public class OntologyAddress : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [ProtoBuf.ProtoMember(1, Name = @"address")]
        [System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get => __pbn__Address ?? "";
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress()
        {
            return __pbn__Address != null;
        }

        public void ResetAddress()
        {
            __pbn__Address = null;
        }

        private string __pbn__Address;

    }
}