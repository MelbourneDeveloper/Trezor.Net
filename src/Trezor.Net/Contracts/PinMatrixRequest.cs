namespace Trezor.Net.Contracts.Common
{
    [global::ProtoBuf.ProtoContract()]
    public class PinMatrixRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(PinMatrixRequestType.PinMatrixRequestTypeCurrent)]
        public PinMatrixRequestType Type
        {
            get { return __pbn__Type ?? PinMatrixRequestType.PinMatrixRequestTypeCurrent; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private PinMatrixRequestType? __pbn__Type;

        [global::ProtoBuf.ProtoContract()]
        public enum PinMatrixRequestType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_Current")]
            PinMatrixRequestTypeCurrent = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewFirst")]
            PinMatrixRequestTypeNewFirst = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"PinMatrixRequestType_NewSecond")]
            PinMatrixRequestTypeNewSecond = 3,
        }

    }
}