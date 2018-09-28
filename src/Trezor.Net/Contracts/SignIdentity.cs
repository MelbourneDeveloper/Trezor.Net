namespace Trezor.Net.Contracts.Crypto
{
    [ProtoBuf.ProtoContract()]
    public class SignIdentity : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"challenge_hidden")]
        public byte[] ChallengeHidden { get; set; }
        public bool ShouldSerializeChallengeHidden() => ChallengeHidden != null;
        public void ResetChallengeHidden() => ChallengeHidden = null;

        [ProtoBuf.ProtoMember(3, Name = @"challenge_visual")]
        [System.ComponentModel.DefaultValue("")]
        public string ChallengeVisual
        {
            get { return __pbn__ChallengeVisual ?? ""; }
            set { __pbn__ChallengeVisual = value; }
        }
        public bool ShouldSerializeChallengeVisual() => __pbn__ChallengeVisual != null;
        public void ResetChallengeVisual() => __pbn__ChallengeVisual = null;
        private string __pbn__ChallengeVisual;

        [ProtoBuf.ProtoMember(4, Name = @"ecdsa_curve_name")]
        [System.ComponentModel.DefaultValue("")]
        public string EcdsaCurveName
        {
            get { return __pbn__EcdsaCurveName ?? ""; }
            set { __pbn__EcdsaCurveName = value; }
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

    }
}