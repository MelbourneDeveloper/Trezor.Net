using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class TxInputType
    {
        [ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoMember(2, Name = @"prev_hash", IsRequired = true)]
        public byte[] PrevHash { get; set; }

        [ProtoMember(3, Name = @"prev_index", IsRequired = true)]
        public uint PrevIndex { get; set; }

        [ProtoMember(4, Name = @"script_sig")]
        public byte[] ScriptSig { get; set; }

        public bool ShouldSerializeScriptSig() => ScriptSig != null;
        public void ResetScriptSig() => ScriptSig = null;

        [ProtoMember(5, Name = @"sequence")]
        [DefaultValue(4294967295)]
        public uint Sequence
        {
            get => __pbn__Sequence ?? 4294967295;
            set => __pbn__Sequence = value;
        }
        public bool ShouldSerializeSequence() => __pbn__Sequence != null;
        public void ResetSequence() => __pbn__Sequence = null;
        private uint? __pbn__Sequence;

        [ProtoMember(6, Name = @"script_type")]
        [DefaultValue(InputScriptType.Spendaddress)]
        public InputScriptType ScriptType
        {
            get => __pbn__ScriptType ?? InputScriptType.Spendaddress;
            set => __pbn__ScriptType = value;
        }
        public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
        public void ResetScriptType() => __pbn__ScriptType = null;
        private InputScriptType? __pbn__ScriptType;

        [ProtoMember(7, Name = @"multisig")]
        public MultisigRedeemScriptType Multisig { get; set; }

        [ProtoMember(8, Name = @"amount")]
        public ulong Amount
        {
            get => __pbn__Amount.GetValueOrDefault();
            set => __pbn__Amount = value;
        }
        public bool ShouldSerializeAmount() => __pbn__Amount != null;
        public void ResetAmount() => __pbn__Amount = null;
        private ulong? __pbn__Amount;

        [ProtoMember(9, Name = @"decred_tree")]
        public uint DecredTree
        {
            get => __pbn__DecredTree.GetValueOrDefault();
            set => __pbn__DecredTree = value;
        }
        public bool ShouldSerializeDecredTree() => __pbn__DecredTree != null;
        public void ResetDecredTree() => __pbn__DecredTree = null;
        private uint? __pbn__DecredTree;

    }
}