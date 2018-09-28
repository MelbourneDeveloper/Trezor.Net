namespace Trezor.Net.Contracts.Bitcoin
{
    [global::ProtoBuf.ProtoContract()]
    public class TxAck : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"tx")]
        public TransactionType Tx { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class TransactionType : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"version")]
            public uint Version
            {
                get { return __pbn__Version.GetValueOrDefault(); }
                set { __pbn__Version = value; }
            }
            public bool ShouldSerializeVersion() => __pbn__Version != null;
            public void ResetVersion() => __pbn__Version = null;
            private uint? __pbn__Version;

            [global::ProtoBuf.ProtoMember(2, Name = @"inputs")]
            public global::System.Collections.Generic.List<TxInputType> Inputs { get; } = new global::System.Collections.Generic.List<TxInputType>();

            [global::ProtoBuf.ProtoMember(3, Name = @"bin_outputs")]
            public global::System.Collections.Generic.List<TxOutputBinType> BinOutputs { get; } = new global::System.Collections.Generic.List<TxOutputBinType>();

            [global::ProtoBuf.ProtoMember(4, Name = @"lock_time")]
            public uint LockTime
            {
                get { return __pbn__LockTime.GetValueOrDefault(); }
                set { __pbn__LockTime = value; }
            }
            public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
            public void ResetLockTime() => __pbn__LockTime = null;
            private uint? __pbn__LockTime;

            [global::ProtoBuf.ProtoMember(5, Name = @"outputs")]
            public global::System.Collections.Generic.List<TxOutputType> Outputs { get; } = new global::System.Collections.Generic.List<TxOutputType>();

            [global::ProtoBuf.ProtoMember(6, Name = @"inputs_cnt")]
            public uint InputsCnt
            {
                get { return __pbn__InputsCnt.GetValueOrDefault(); }
                set { __pbn__InputsCnt = value; }
            }
            public bool ShouldSerializeInputsCnt() => __pbn__InputsCnt != null;
            public void ResetInputsCnt() => __pbn__InputsCnt = null;
            private uint? __pbn__InputsCnt;

            [global::ProtoBuf.ProtoMember(7, Name = @"outputs_cnt")]
            public uint OutputsCnt
            {
                get { return __pbn__OutputsCnt.GetValueOrDefault(); }
                set { __pbn__OutputsCnt = value; }
            }
            public bool ShouldSerializeOutputsCnt() => __pbn__OutputsCnt != null;
            public void ResetOutputsCnt() => __pbn__OutputsCnt = null;
            private uint? __pbn__OutputsCnt;

            [global::ProtoBuf.ProtoMember(8, Name = @"extra_data")]
            public byte[] ExtraData
            {
                get { return __pbn__ExtraData; }
                set { __pbn__ExtraData = value; }
            }
            public bool ShouldSerializeExtraData() => __pbn__ExtraData != null;
            public void ResetExtraData() => __pbn__ExtraData = null;
            private byte[] __pbn__ExtraData;

            [global::ProtoBuf.ProtoMember(9, Name = @"extra_data_len")]
            public uint ExtraDataLen
            {
                get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
                set { __pbn__ExtraDataLen = value; }
            }
            public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
            public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
            private uint? __pbn__ExtraDataLen;

            [global::ProtoBuf.ProtoMember(10, Name = @"expiry")]
            public uint Expiry
            {
                get { return __pbn__Expiry.GetValueOrDefault(); }
                set { __pbn__Expiry = value; }
            }
            public bool ShouldSerializeExpiry() => __pbn__Expiry != null;
            public void ResetExpiry() => __pbn__Expiry = null;
            private uint? __pbn__Expiry;

            [global::ProtoBuf.ProtoMember(11, Name = @"overwintered")]
            public bool Overwintered
            {
                get { return __pbn__Overwintered.GetValueOrDefault(); }
                set { __pbn__Overwintered = value; }
            }
            public bool ShouldSerializeOverwintered() => __pbn__Overwintered != null;
            public void ResetOverwintered() => __pbn__Overwintered = null;
            private bool? __pbn__Overwintered;

            [global::ProtoBuf.ProtoContract()]
            public class TxInputType : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
                public uint[] AddressNs { get; set; }

                [global::ProtoBuf.ProtoMember(2, Name = @"prev_hash", IsRequired = true)]
                public byte[] PrevHash { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"prev_index", IsRequired = true)]
                public uint PrevIndex { get; set; }

                [global::ProtoBuf.ProtoMember(4, Name = @"script_sig")]
                public byte[] ScriptSig
                {
                    get { return __pbn__ScriptSig; }
                    set { __pbn__ScriptSig = value; }
                }
                public bool ShouldSerializeScriptSig() => __pbn__ScriptSig != null;
                public void ResetScriptSig() => __pbn__ScriptSig = null;
                private byte[] __pbn__ScriptSig;

                [global::ProtoBuf.ProtoMember(5, Name = @"sequence")]
                [global::System.ComponentModel.DefaultValue(4294967295)]
                public uint Sequence
                {
                    get { return __pbn__Sequence ?? 4294967295; }
                    set { __pbn__Sequence = value; }
                }
                public bool ShouldSerializeSequence() => __pbn__Sequence != null;
                public void ResetSequence() => __pbn__Sequence = null;
                private uint? __pbn__Sequence;

                [global::ProtoBuf.ProtoMember(6, Name = @"script_type")]
                [global::System.ComponentModel.DefaultValue(InputScriptType.Spendaddress)]
                public InputScriptType ScriptType
                {
                    get { return __pbn__ScriptType ?? InputScriptType.Spendaddress; }
                    set { __pbn__ScriptType = value; }
                }
                public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
                public void ResetScriptType() => __pbn__ScriptType = null;
                private InputScriptType? __pbn__ScriptType;

                [global::ProtoBuf.ProtoMember(7, Name = @"multisig")]
                public MultisigRedeemScriptType Multisig { get; set; }

                [global::ProtoBuf.ProtoMember(8, Name = @"amount")]
                public ulong Amount
                {
                    get { return __pbn__Amount.GetValueOrDefault(); }
                    set { __pbn__Amount = value; }
                }
                public bool ShouldSerializeAmount() => __pbn__Amount != null;
                public void ResetAmount() => __pbn__Amount = null;
                private ulong? __pbn__Amount;

                [global::ProtoBuf.ProtoMember(9, Name = @"decred_tree")]
                public uint DecredTree
                {
                    get { return __pbn__DecredTree.GetValueOrDefault(); }
                    set { __pbn__DecredTree = value; }
                }
                public bool ShouldSerializeDecredTree() => __pbn__DecredTree != null;
                public void ResetDecredTree() => __pbn__DecredTree = null;
                private uint? __pbn__DecredTree;

                [global::ProtoBuf.ProtoMember(10, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

                [global::ProtoBuf.ProtoMember(11, Name = @"prev_block_hash_bip115")]
                public byte[] PrevBlockHashBip115
                {
                    get { return __pbn__PrevBlockHashBip115; }
                    set { __pbn__PrevBlockHashBip115 = value; }
                }
                public bool ShouldSerializePrevBlockHashBip115() => __pbn__PrevBlockHashBip115 != null;
                public void ResetPrevBlockHashBip115() => __pbn__PrevBlockHashBip115 = null;
                private byte[] __pbn__PrevBlockHashBip115;

                [global::ProtoBuf.ProtoMember(12, Name = @"prev_block_height_bip115")]
                public uint PrevBlockHeightBip115
                {
                    get { return __pbn__PrevBlockHeightBip115.GetValueOrDefault(); }
                    set { __pbn__PrevBlockHeightBip115 = value; }
                }
                public bool ShouldSerializePrevBlockHeightBip115() => __pbn__PrevBlockHeightBip115 != null;
                public void ResetPrevBlockHeightBip115() => __pbn__PrevBlockHeightBip115 = null;
                private uint? __pbn__PrevBlockHeightBip115;

            }

            [global::ProtoBuf.ProtoContract()]
            public class TxOutputBinType : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"amount", IsRequired = true)]
                public ulong Amount { get; set; }

                [global::ProtoBuf.ProtoMember(2, Name = @"script_pubkey", IsRequired = true)]
                public byte[] ScriptPubkey { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

            }

            [global::ProtoBuf.ProtoContract()]
            public class TxOutputType : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"address")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Address
                {
                    get { return __pbn__Address ?? ""; }
                    set { __pbn__Address = value; }
                }
                public bool ShouldSerializeAddress() => __pbn__Address != null;
                public void ResetAddress() => __pbn__Address = null;
                private string __pbn__Address;

                [global::ProtoBuf.ProtoMember(2, Name = @"address_n")]
                public uint[] AddressNs { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"amount", IsRequired = true)]
                public ulong Amount { get; set; }

                [global::ProtoBuf.ProtoMember(4, Name = @"script_type", IsRequired = true)]
                public OutputScriptType ScriptType { get; set; }

                [global::ProtoBuf.ProtoMember(5, Name = @"multisig")]
                public MultisigRedeemScriptType Multisig { get; set; }

                [global::ProtoBuf.ProtoMember(6, Name = @"op_return_data")]
                public byte[] OpReturnData
                {
                    get { return __pbn__OpReturnData; }
                    set { __pbn__OpReturnData = value; }
                }
                public bool ShouldSerializeOpReturnData() => __pbn__OpReturnData != null;
                public void ResetOpReturnData() => __pbn__OpReturnData = null;
                private byte[] __pbn__OpReturnData;

                [global::ProtoBuf.ProtoMember(7, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

                [global::ProtoBuf.ProtoMember(8, Name = @"block_hash_bip115")]
                public byte[] BlockHashBip115
                {
                    get { return __pbn__BlockHashBip115; }
                    set { __pbn__BlockHashBip115 = value; }
                }
                public bool ShouldSerializeBlockHashBip115() => __pbn__BlockHashBip115 != null;
                public void ResetBlockHashBip115() => __pbn__BlockHashBip115 = null;
                private byte[] __pbn__BlockHashBip115;

                [global::ProtoBuf.ProtoMember(9, Name = @"block_height_bip115")]
                public uint BlockHeightBip115
                {
                    get { return __pbn__BlockHeightBip115.GetValueOrDefault(); }
                    set { __pbn__BlockHeightBip115 = value; }
                }
                public bool ShouldSerializeBlockHeightBip115() => __pbn__BlockHeightBip115 != null;
                public void ResetBlockHeightBip115() => __pbn__BlockHeightBip115 = null;
                private uint? __pbn__BlockHeightBip115;

                [global::ProtoBuf.ProtoContract()]
                public enum OutputScriptType
                {
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOADDRESS")]
                    Paytoaddress = 0,
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOSCRIPTHASH")]
                    Paytoscripthash = 1,
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOMULTISIG")]
                    Paytomultisig = 2,
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOOPRETURN")]
                    Paytoopreturn = 3,
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOWITNESS")]
                    Paytowitness = 4,
                    [global::ProtoBuf.ProtoEnum(Name = @"PAYTOP2SHWITNESS")]
                    Paytop2shwitness = 5,
                }

            }

        }

    }
}