using ProtoBuf;

namespace Trezor.Net.Contracts
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