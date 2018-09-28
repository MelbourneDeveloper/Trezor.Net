namespace Trezor.Net.Contracts.Common
{
    [ProtoBuf.ProtoContract()]
    public class PinMatrixRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"type")]
        [System.ComponentModel.DefaultValue(PinMatrixRequestType.PinMatrixRequestTypeCurrent)]
        public PinMatrixRequestType Type
        {
            get { return __pbn__Type ?? PinMatrixRequestType.PinMatrixRequestTypeCurrent; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private PinMatrixRequestType? __pbn__Type;

        [ProtoBuf.ProtoContract()]
        public enum PinMatrixRequestType
        {
            [ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_Current")]
            PinMatrixRequestTypeCurrent = 1,
            [ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewFirst")]
            PinMatrixRequestTypeNewFirst = 2,
            [ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewSecond")]
            PinMatrixRequestTypeNewSecond = 3,
        }

    }
}