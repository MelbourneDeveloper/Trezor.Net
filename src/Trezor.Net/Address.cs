using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class Address
    {
        #region Proto Members
        [ProtoMember(1, IsRequired = true)]
        public string address { get; set; }
        #endregion
    }
}