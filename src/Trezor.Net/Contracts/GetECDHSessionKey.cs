using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class GetECDHSessionKey
    {
        [ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [ProtoMember(2, Name = @"peer_public_key")]
        public byte[] PeerPublicKey { get; set; }

        public bool ShouldSerializePeerPublicKey() => PeerPublicKey != null;
        public void ResetPeerPublicKey() => PeerPublicKey = null;

        [ProtoMember(3, Name = @"ecdsa_curve_name")]
        [DefaultValue("")]
        public string EcdsaCurveName
        {
            get => __pbn__EcdsaCurveName ?? "";
            set => __pbn__EcdsaCurveName = value;
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

    }
}