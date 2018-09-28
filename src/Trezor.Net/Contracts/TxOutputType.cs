using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class TxOutputType
    {
        [ProtoMember(1, Name = @"address")]
        [DefaultValue("")]
        public string Address
        {
            get => __pbn__Address ?? "";
            set => __pbn__Address = value;
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [ProtoMember(2, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(3, Name = @"amount", IsRequired = true)]
        public ulong Amount { get; set; }

        [ProtoMember(4, Name = @"script_type", IsRequired = true)]
        public OutputScriptType ScriptType { get; set; }

        [ProtoMember(5, Name = @"multisig")]
        public MultisigRedeemScriptType Multisig { get; set; }

        [ProtoMember(6, Name = @"op_return_data")]
        public byte[] OpReturnData { get; set; }

        public bool ShouldSerializeOpReturnData() => OpReturnData != null;
        public void ResetOpReturnData() => OpReturnData = null;

        [ProtoMember(7, Name = @"decred_script_version")]
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