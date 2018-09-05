using System.Collections.Generic;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class MultisigRedeemScriptType
    {
        [ProtoMember(1, Name = @"pubkeys")]
        public List<HDNodePathType> Pubkeys { get; } = new List<HDNodePathType>();

        [ProtoMember(2, Name = @"signatures")]
        public List<byte[]> Signatures { get; } = new List<byte[]>();

        [ProtoMember(3, Name = @"m")]
        public uint M
        {
            get => __pbn__M.GetValueOrDefault();
            set => __pbn__M = value;
        }
        public bool ShouldSerializeM() => __pbn__M != null;
        public void ResetM() => __pbn__M = null;
        private uint? __pbn__M;

    }
}