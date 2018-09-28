namespace Trezor.Net.Contracts.Management
{
    [global::ProtoBuf.ProtoContract()]
    public class WordRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(WordRequestType.WordRequestTypePlain)]
        public WordRequestType Type
        {
            get { return __pbn__Type ?? WordRequestType.WordRequestTypePlain; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private WordRequestType? __pbn__Type;

        [global::ProtoBuf.ProtoContract()]
        public enum WordRequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"WordRequestType_Plain")]
            WordRequestTypePlain = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"WordRequestType_Matrix9")]
            WordRequestTypeMatrix9 = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"WordRequestType_Matrix6")]
            WordRequestTypeMatrix6 = 2,
        }

    }
}