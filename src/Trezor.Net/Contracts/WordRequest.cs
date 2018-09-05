using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class WordRequest
    {
        [ProtoMember(1, Name = @"type")]
        [DefaultValue(WordRequestType.WordRequestTypePlain)]
        public WordRequestType Type
        {
            get => __pbn__Type ?? WordRequestType.WordRequestTypePlain;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private WordRequestType? __pbn__Type;

    }
}