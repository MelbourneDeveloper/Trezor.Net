namespace Trezor.Net.Contracts.Crypto
{
    [global::ProtoBuf.ProtoContract()]
    public class SignIdentity : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"challenge_hidden")]
        public byte[] ChallengeHidden
        {
            get { return __pbn__ChallengeHidden; }
            set { __pbn__ChallengeHidden = value; }
        }
        public bool ShouldSerializeChallengeHidden() => __pbn__ChallengeHidden != null;
        public void ResetChallengeHidden() => __pbn__ChallengeHidden = null;
        private byte[] __pbn__ChallengeHidden;

        [global::ProtoBuf.ProtoMember(3, Name = @"challenge_visual")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChallengeVisual
        {
            get { return __pbn__ChallengeVisual ?? ""; }
            set { __pbn__ChallengeVisual = value; }
        }
        public bool ShouldSerializeChallengeVisual() => __pbn__ChallengeVisual != null;
        public void ResetChallengeVisual() => __pbn__ChallengeVisual = null;
        private string __pbn__ChallengeVisual;

        [global::ProtoBuf.ProtoMember(4, Name = @"ecdsa_curve_name")]
        [global::System.ComponentModel.DefaultValue("")]
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