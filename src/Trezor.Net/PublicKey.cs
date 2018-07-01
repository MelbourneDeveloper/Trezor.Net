using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class PublicKey
    {
        [ProtoMember(1, Name = @"node", IsRequired = true)]
        public HDNodeType Node { get; set; }

        [ProtoMember(2, Name = @"xpub")]
        [DefaultValue("")]
        public string Xpub
        {
            get => __pbn__Xpub ?? "";
            set => __pbn__Xpub = value;
        }
        public bool ShouldSerializeXpub() => __pbn__Xpub != null;
        public void ResetXpub() => __pbn__Xpub = null;
        private string __pbn__Xpub;

    }
}