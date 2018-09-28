namespace Trezor.Net.Contracts.Ontology
{
    [global::ProtoBuf.ProtoContract()]
    public class OntologyAddress : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
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