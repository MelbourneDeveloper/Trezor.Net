using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class SignIdentity
    {
        [ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [ProtoMember(2, Name = @"challenge_hidden")]
        public byte[] ChallengeHidden { get; set; }

        public bool ShouldSerializeChallengeHidden() => ChallengeHidden != null;
        public void ResetChallengeHidden() => ChallengeHidden = null;

        [ProtoMember(3, Name = @"challenge_visual")]
        [DefaultValue("")]
        public string ChallengeVisual
        {
            get => __pbn__ChallengeVisual ?? "";
            set => __pbn__ChallengeVisual = value;
        }
        public bool ShouldSerializeChallengeVisual() => __pbn__ChallengeVisual != null;
        public void ResetChallengeVisual() => __pbn__ChallengeVisual = null;
        private string __pbn__ChallengeVisual;

        [ProtoMember(4, Name = @"ecdsa_curve_name")]
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