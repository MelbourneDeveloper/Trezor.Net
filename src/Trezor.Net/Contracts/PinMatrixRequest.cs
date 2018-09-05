using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class PinMatrixRequest
    {
        [ProtoMember(1, Name = @"type")]
        [DefaultValue(PinMatrixRequestType.PinMatrixRequestTypeCurrent)]
        public PinMatrixRequestType Type
        {
            get => __pbn__Type ?? PinMatrixRequestType.PinMatrixRequestTypeCurrent;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private PinMatrixRequestType? __pbn__Type;

    }
}