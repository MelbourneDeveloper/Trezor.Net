namespace Trezor.Net.Contracts.Management
{
    [ProtoBuf.ProtoContract()]
    public class WordRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"type")]
        [System.ComponentModel.DefaultValue(WordRequestType.WordRequestTypePlain)]
        public WordRequestType Type
        {
            get { return __pbn__Type ?? WordRequestType.WordRequestTypePlain; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private WordRequestType? __pbn__Type;

        [ProtoBuf.ProtoContract()]
        public enum WordRequestType
        {
            [ProtoBuf.ProtoEnum(Name = @"WordRequestType_Plain")]
            WordRequestTypePlain = 0,
            [ProtoBuf.ProtoEnum(Name = @"WordRequestType_Matrix9")]
            WordRequestTypeMatrix9 = 1,
            [ProtoBuf.ProtoEnum(Name = @"WordRequestType_Matrix6")]
            WordRequestTypeMatrix6 = 2,
        }

    }
}