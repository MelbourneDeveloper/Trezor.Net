namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public class TxAck : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"tx")]
        public TransactionType Tx { get; set; }

        [ProtoBuf.ProtoContract()]
        public class TransactionType : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"version")]
            public uint Version
            {
                get { return __pbn__Version.GetValueOrDefault(); }
                set { __pbn__Version = value; }
            }
            public bool ShouldSerializeVersion() => __pbn__Version != null;
            public void ResetVersion() => __pbn__Version = null;
            private uint? __pbn__Version;

            [ProtoBuf.ProtoMember(2, Name = @"inputs")]
            public System.Collections.Generic.List<TxInputType> Inputs { get; } = new System.Collections.Generic.List<TxInputType>();

            [ProtoBuf.ProtoMember(3, Name = @"bin_outputs")]
            public System.Collections.Generic.List<TxOutputBinType> BinOutputs { get; } = new System.Collections.Generic.List<TxOutputBinType>();

            [ProtoBuf.ProtoMember(4, Name = @"lock_time")]
            public uint LockTime
            {
                get { return __pbn__LockTime.GetValueOrDefault(); }
                set { __pbn__LockTime = value; }
            }
            public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
            public void ResetLockTime() => __pbn__LockTime = null;
            private uint? __pbn__LockTime;

            [ProtoBuf.ProtoMember(5, Name = @"outputs")]
            public System.Collections.Generic.List<TxOutputType> Outputs { get; } = new System.Collections.Generic.List<TxOutputType>();

            [ProtoBuf.ProtoMember(6, Name = @"inputs_cnt")]
            public uint InputsCnt
            {
                get { return __pbn__InputsCnt.GetValueOrDefault(); }
                set { __pbn__InputsCnt = value; }
            }
            public bool ShouldSerializeInputsCnt() => __pbn__InputsCnt != null;
            public void ResetInputsCnt() => __pbn__InputsCnt = null;
            private uint? __pbn__InputsCnt;

            [ProtoBuf.ProtoMember(7, Name = @"outputs_cnt")]
            public uint OutputsCnt
            {
                get { return __pbn__OutputsCnt.GetValueOrDefault(); }
                set { __pbn__OutputsCnt = value; }
            }
            public bool ShouldSerializeOutputsCnt() => __pbn__OutputsCnt != null;
            public void ResetOutputsCnt() => __pbn__OutputsCnt = null;
            private uint? __pbn__OutputsCnt;

            [ProtoBuf.ProtoMember(8, Name = @"extra_data")]
            public byte[] ExtraData { get; set; }
            public bool ShouldSerializeExtraData() => ExtraData != null;
            public void ResetExtraData() => ExtraData = null;

            [ProtoBuf.ProtoMember(9, Name = @"extra_data_len")]
            public uint ExtraDataLen
            {
                get { return __pbn__ExtraDataLen.GetValueOrDefault(); }
                set { __pbn__ExtraDataLen = value; }
            }
            public bool ShouldSerializeExtraDataLen() => __pbn__ExtraDataLen != null;
            public void ResetExtraDataLen() => __pbn__ExtraDataLen = null;
            private uint? __pbn__ExtraDataLen;

            [ProtoBuf.ProtoMember(10, Name = @"expiry")]
            public uint Expiry
            {
                get { return __pbn__Expiry.GetValueOrDefault(); }
                set { __pbn__Expiry = value; }
            }
            public bool ShouldSerializeExpiry() => __pbn__Expiry != null;
            public void ResetExpiry() => __pbn__Expiry = null;
            private uint? __pbn__Expiry;

            [ProtoBuf.ProtoMember(11, Name = @"overwintered")]
            public bool Overwintered
            {
                get { return __pbn__Overwintered.GetValueOrDefault(); }
                set { __pbn__Overwintered = value; }
            }
            public bool ShouldSerializeOverwintered() => __pbn__Overwintered != null;
            public void ResetOverwintered() => __pbn__Overwintered = null;
            private bool? __pbn__Overwintered;

            [ProtoBuf.ProtoContract()]
            public class TxInputType : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"address_n")]
                public uint[] AddressNs { get; set; }

                [ProtoBuf.ProtoMember(2, Name = @"prev_hash", IsRequired = true)]
                public byte[] PrevHash { get; set; }

                [ProtoBuf.ProtoMember(3, Name = @"prev_index", IsRequired = true)]
                public uint PrevIndex { get; set; }

                [ProtoBuf.ProtoMember(4, Name = @"script_sig")]
                public byte[] ScriptSig { get; set; }
                public bool ShouldSerializeScriptSig() => ScriptSig != null;
                public void ResetScriptSig() => ScriptSig = null;

                [ProtoBuf.ProtoMember(5, Name = @"sequence")]
                [System.ComponentModel.DefaultValue(4294967295)]
                public uint Sequence
                {
                    get { return __pbn__Sequence ?? 4294967295; }
                    set { __pbn__Sequence = value; }
                }
                public bool ShouldSerializeSequence() => __pbn__Sequence != null;
                public void ResetSequence() => __pbn__Sequence = null;
                private uint? __pbn__Sequence;

                [ProtoBuf.ProtoMember(6, Name = @"script_type")]
                [System.ComponentModel.DefaultValue(InputScriptType.Spendaddress)]
                public InputScriptType ScriptType
                {
                    get { return __pbn__ScriptType ?? InputScriptType.Spendaddress; }
                    set { __pbn__ScriptType = value; }
                }
                public bool ShouldSerializeScriptType() => __pbn__ScriptType != null;
                public void ResetScriptType() => __pbn__ScriptType = null;
                private InputScriptType? __pbn__ScriptType;

                [ProtoBuf.ProtoMember(7, Name = @"multisig")]
                public MultisigRedeemScriptType Multisig { get; set; }

                [ProtoBuf.ProtoMember(8, Name = @"amount")]
                public ulong Amount
                {
                    get { return __pbn__Amount.GetValueOrDefault(); }
                    set { __pbn__Amount = value; }
                }
                public bool ShouldSerializeAmount() => __pbn__Amount != null;
                public void ResetAmount() => __pbn__Amount = null;
                private ulong? __pbn__Amount;

                [ProtoBuf.ProtoMember(9, Name = @"decred_tree")]
                public uint DecredTree
                {
                    get { return __pbn__DecredTree.GetValueOrDefault(); }
                    set { __pbn__DecredTree = value; }
                }
                public bool ShouldSerializeDecredTree() => __pbn__DecredTree != null;
                public void ResetDecredTree() => __pbn__DecredTree = null;
                private uint? __pbn__DecredTree;

                [ProtoBuf.ProtoMember(10, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

                [ProtoBuf.ProtoMember(11, Name = @"prev_block_hash_bip115")]
                public byte[] PrevBlockHashBip115 { get; set; }
                public bool ShouldSerializePrevBlockHashBip115() => PrevBlockHashBip115 != null;
                public void ResetPrevBlockHashBip115() => PrevBlockHashBip115 = null;

                [ProtoBuf.ProtoMember(12, Name = @"prev_block_height_bip115")]
                public uint PrevBlockHeightBip115
                {
                    get { return __pbn__PrevBlockHeightBip115.GetValueOrDefault(); }
                    set { __pbn__PrevBlockHeightBip115 = value; }
                }
                public bool ShouldSerializePrevBlockHeightBip115() => __pbn__PrevBlockHeightBip115 != null;
                public void ResetPrevBlockHeightBip115() => __pbn__PrevBlockHeightBip115 = null;
                private uint? __pbn__PrevBlockHeightBip115;

            }

            [ProtoBuf.ProtoContract()]
            public class TxOutputBinType : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"amount", IsRequired = true)]
                public ulong Amount { get; set; }

                [ProtoBuf.ProtoMember(2, Name = @"script_pubkey", IsRequired = true)]
                public byte[] ScriptPubkey { get; set; }

                [ProtoBuf.ProtoMember(3, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

            }

            [ProtoBuf.ProtoContract()]
            public class TxOutputType : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"address")]
                [System.ComponentModel.DefaultValue("")]
                public string Address
                {
                    get { return __pbn__Address ?? ""; }
                    set { __pbn__Address = value; }
                }
                public bool ShouldSerializeAddress() => __pbn__Address != null;
                public void ResetAddress() => __pbn__Address = null;
                private string __pbn__Address;

                [ProtoBuf.ProtoMember(2, Name = @"address_n")]
                public uint[] AddressNs { get; set; }

                [ProtoBuf.ProtoMember(3, Name = @"amount", IsRequired = true)]
                public ulong Amount { get; set; }

                [ProtoBuf.ProtoMember(4, Name = @"script_type", IsRequired = true)]
                public OutputScriptType ScriptType { get; set; }

                [ProtoBuf.ProtoMember(5, Name = @"multisig")]
                public MultisigRedeemScriptType Multisig { get; set; }

                [ProtoBuf.ProtoMember(6, Name = @"op_return_data")]
                public byte[] OpReturnData { get; set; }
                public bool ShouldSerializeOpReturnData() => OpReturnData != null;
                public void ResetOpReturnData() => OpReturnData = null;

                [ProtoBuf.ProtoMember(7, Name = @"decred_script_version")]
                public uint DecredScriptVersion
                {
                    get { return __pbn__DecredScriptVersion.GetValueOrDefault(); }
                    set { __pbn__DecredScriptVersion = value; }
                }
                public bool ShouldSerializeDecredScriptVersion() => __pbn__DecredScriptVersion != null;
                public void ResetDecredScriptVersion() => __pbn__DecredScriptVersion = null;
                private uint? __pbn__DecredScriptVersion;

                [ProtoBuf.ProtoMember(8, Name = @"block_hash_bip115")]
                public byte[] BlockHashBip115 { get; set; }
                public bool ShouldSerializeBlockHashBip115() => BlockHashBip115 != null;
                public void ResetBlockHashBip115() => BlockHashBip115 = null;

                [ProtoBuf.ProtoMember(9, Name = @"block_height_bip115")]
                public uint BlockHeightBip115
                {
                    get { return __pbn__BlockHeightBip115.GetValueOrDefault(); }
                    set { __pbn__BlockHeightBip115 = value; }
                }
                public bool ShouldSerializeBlockHeightBip115() => __pbn__BlockHeightBip115 != null;
                public void ResetBlockHeightBip115() => __pbn__BlockHeightBip115 = null;
                private uint? __pbn__BlockHeightBip115;

                [ProtoBuf.ProtoContract()]
                public enum OutputScriptType
                {
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOADDRESS")]
                    Paytoaddress = 0,
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOSCRIPTHASH")]
                    Paytoscripthash = 1,
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOMULTISIG")]
                    Paytomultisig = 2,
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOOPRETURN")]
                    Paytoopreturn = 3,
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOWITNESS")]
                    Paytowitness = 4,
                    [ProtoBuf.ProtoEnum(Name = @"PAYTOP2SHWITNESS")]
                    Paytop2shwitness = 5,
                }

            }

        }

    }
}