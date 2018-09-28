using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class TxOutputBinType
    {
        [ProtoMember(1, Name = @"amount", IsRequired = true)]
        public ulong Amount { get; set; }

        [ProtoMember(2, Name = @"script_pubkey", IsRequired = true)]
        public byte[] ScriptPubkey { get; set; }

        [ProtoMember(3, Name = @"decred_script_version")]
        public uint DecredScriptVersion
        {
            get => __pbn__DecredScriptVersion.GetValueOrDefault();
            set => __pbn__DecredScriptVersion = value;
        }
        public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
        public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
        private uint? __pbn__DecredScriptVersion;

    }
}