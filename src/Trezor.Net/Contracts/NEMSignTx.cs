namespace Trezor.Net.Contracts.NEM
{
    [ProtoBuf.ProtoContract()]
    public class NEMSignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"transaction")]
        public NEMTransactionCommon Transaction { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"multisig")]
        public NEMTransactionCommon Multisig { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"transfer")]
        public NEMTransfer Transfer { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"cosigning")]
        public bool Cosigning
        {
            get { return __pbn__Cosigning.GetValueOrDefault(); }
            set { __pbn__Cosigning = value; }
        }
        public bool ShouldSerializeCosigning() => __pbn__Cosigning != null;
        public void ResetCosigning() => __pbn__Cosigning = null;
        private bool? __pbn__Cosigning;

        [ProtoBuf.ProtoMember(5, Name = @"provision_namespace")]
        public NEMProvisionNamespace ProvisionNamespace { get; set; }

        [ProtoBuf.ProtoMember(6, Name = @"mosaic_creation")]
        public NEMMosaicCreation MosaicCreation { get; set; }

        [ProtoBuf.ProtoMember(7, Name = @"supply_change")]
        public NEMMosaicSupplyChange SupplyChange { get; set; }

        [ProtoBuf.ProtoMember(8, Name = @"aggregate_modification")]
        public NEMAggregateModification AggregateModification { get; set; }

        [ProtoBuf.ProtoMember(9, Name = @"importance_transfer")]
        public NEMImportanceTransfer ImportanceTransfer { get; set; }

        [ProtoBuf.ProtoContract()]
        public class NEMTransactionCommon : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"address_n")]
            public uint[] AddressNs { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"network")]
            public uint Network
            {
                get { return __pbn__Network.GetValueOrDefault(); }
                set { __pbn__Network = value; }
            }
            public bool ShouldSerializeNetwork() => __pbn__Network != null;
            public void ResetNetwork() => __pbn__Network = null;
            private uint? __pbn__Network;

            [ProtoBuf.ProtoMember(3, Name = @"timestamp")]
            public uint Timestamp
            {
                get { return __pbn__Timestamp.GetValueOrDefault(); }
                set { __pbn__Timestamp = value; }
            }
            public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
            public void ResetTimestamp() => __pbn__Timestamp = null;
            private uint? __pbn__Timestamp;

            [ProtoBuf.ProtoMember(4, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoMember(5, Name = @"deadline")]
            public uint Deadline
            {
                get { return __pbn__Deadline.GetValueOrDefault(); }
                set { __pbn__Deadline = value; }
            }
            public bool ShouldSerializeDeadline() => __pbn__Deadline != null;
            public void ResetDeadline() => __pbn__Deadline = null;
            private uint? __pbn__Deadline;

            [ProtoBuf.ProtoMember(6, Name = @"signer")]
            public byte[] Signer
            {
                get { return __pbn__Signer; }
                set { __pbn__Signer = value; }
            }
            public bool ShouldSerializeSigner() => __pbn__Signer != null;
            public void ResetSigner() => __pbn__Signer = null;
            private byte[] __pbn__Signer;

        }

        [ProtoBuf.ProtoContract()]
        public class NEMTransfer : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"recipient")]
            [System.ComponentModel.DefaultValue("")]
            public string Recipient
            {
                get { return __pbn__Recipient ?? ""; }
                set { __pbn__Recipient = value; }
            }
            public bool ShouldSerializeRecipient() => __pbn__Recipient != null;
            public void ResetRecipient() => __pbn__Recipient = null;
            private string __pbn__Recipient;

            [ProtoBuf.ProtoMember(2, Name = @"amount")]
            public ulong Amount
            {
                get { return __pbn__Amount.GetValueOrDefault(); }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

            [ProtoBuf.ProtoMember(3, Name = @"payload")]
            public byte[] Payload
            {
                get { return __pbn__Payload; }
                set { __pbn__Payload = value; }
            }
            public bool ShouldSerializePayload() => __pbn__Payload != null;
            public void ResetPayload() => __pbn__Payload = null;
            private byte[] __pbn__Payload;

            [ProtoBuf.ProtoMember(4, Name = @"public_key")]
            public byte[] PublicKey
            {
                get { return __pbn__PublicKey; }
                set { __pbn__PublicKey = value; }
            }
            public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
            public void ResetPublicKey() => __pbn__PublicKey = null;
            private byte[] __pbn__PublicKey;

            [ProtoBuf.ProtoMember(5, Name = @"mosaics")]
            public System.Collections.Generic.List<NEMMosaic> Mosaics { get; } = new System.Collections.Generic.List<NEMMosaic>();

            [ProtoBuf.ProtoContract()]
            public class NEMMosaic : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"namespace")]
                [System.ComponentModel.DefaultValue("")]
                public string Namespace
                {
                    get { return __pbn__Namespace ?? ""; }
                    set { __pbn__Namespace = value; }
                }
                public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
                public void ResetNamespace() => __pbn__Namespace = null;
                private string __pbn__Namespace;

                [ProtoBuf.ProtoMember(2, Name = @"mosaic")]
                [System.ComponentModel.DefaultValue("")]
                public string Mosaic
                {
                    get { return __pbn__Mosaic ?? ""; }
                    set { __pbn__Mosaic = value; }
                }
                public bool ShouldSerializeMosaic() => __pbn__Mosaic != null;
                public void ResetMosaic() => __pbn__Mosaic = null;
                private string __pbn__Mosaic;

                [ProtoBuf.ProtoMember(3, Name = @"quantity")]
                public ulong Quantity
                {
                    get { return __pbn__Quantity.GetValueOrDefault(); }
                    set { __pbn__Quantity = value; }
                }
                public bool ShouldSerializeQuantity() => __pbn__Quantity != null;
                public void ResetQuantity() => __pbn__Quantity = null;
                private ulong? __pbn__Quantity;

            }

        }

        [ProtoBuf.ProtoContract()]
        public class NEMProvisionNamespace : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"namespace")]
            [System.ComponentModel.DefaultValue("")]
            public string Namespace
            {
                get { return __pbn__Namespace ?? ""; }
                set { __pbn__Namespace = value; }
            }
            public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
            public void ResetNamespace() => __pbn__Namespace = null;
            private string __pbn__Namespace;

            [ProtoBuf.ProtoMember(2, Name = @"parent")]
            [System.ComponentModel.DefaultValue("")]
            public string Parent
            {
                get { return __pbn__Parent ?? ""; }
                set { __pbn__Parent = value; }
            }
            public bool ShouldSerializeParent() => __pbn__Parent != null;
            public void ResetParent() => __pbn__Parent = null;
            private string __pbn__Parent;

            [ProtoBuf.ProtoMember(3, Name = @"sink")]
            [System.ComponentModel.DefaultValue("")]
            public string Sink
            {
                get { return __pbn__Sink ?? ""; }
                set { __pbn__Sink = value; }
            }
            public bool ShouldSerializeSink() => __pbn__Sink != null;
            public void ResetSink() => __pbn__Sink = null;
            private string __pbn__Sink;

            [ProtoBuf.ProtoMember(4, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

        }

        [ProtoBuf.ProtoContract()]
        public class NEMMosaicCreation : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"definition")]
            public NEMMosaicDefinition Definition { get; set; }

            [ProtoBuf.ProtoMember(2, Name = @"sink")]
            [System.ComponentModel.DefaultValue("")]
            public string Sink
            {
                get { return __pbn__Sink ?? ""; }
                set { __pbn__Sink = value; }
            }
            public bool ShouldSerializeSink() => __pbn__Sink != null;
            public void ResetSink() => __pbn__Sink = null;
            private string __pbn__Sink;

            [ProtoBuf.ProtoMember(3, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [ProtoBuf.ProtoContract()]
            public class NEMMosaicDefinition : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"name")]
                [System.ComponentModel.DefaultValue("")]
                public string Name
                {
                    get { return __pbn__Name ?? ""; }
                    set { __pbn__Name = value; }
                }
                public bool ShouldSerializeName() => __pbn__Name != null;
                public void ResetName() => __pbn__Name = null;
                private string __pbn__Name;

                [ProtoBuf.ProtoMember(2, Name = @"ticker")]
                [System.ComponentModel.DefaultValue("")]
                public string Ticker
                {
                    get { return __pbn__Ticker ?? ""; }
                    set { __pbn__Ticker = value; }
                }
                public bool ShouldSerializeTicker() => __pbn__Ticker != null;
                public void ResetTicker() => __pbn__Ticker = null;
                private string __pbn__Ticker;

                [ProtoBuf.ProtoMember(3, Name = @"namespace")]
                [System.ComponentModel.DefaultValue("")]
                public string Namespace
                {
                    get { return __pbn__Namespace ?? ""; }
                    set { __pbn__Namespace = value; }
                }
                public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
                public void ResetNamespace() => __pbn__Namespace = null;
                private string __pbn__Namespace;

                [ProtoBuf.ProtoMember(4, Name = @"mosaic")]
                [System.ComponentModel.DefaultValue("")]
                public string Mosaic
                {
                    get { return __pbn__Mosaic ?? ""; }
                    set { __pbn__Mosaic = value; }
                }
                public bool ShouldSerializeMosaic() => __pbn__Mosaic != null;
                public void ResetMosaic() => __pbn__Mosaic = null;
                private string __pbn__Mosaic;

                [ProtoBuf.ProtoMember(5, Name = @"divisibility")]
                public uint Divisibility
                {
                    get { return __pbn__Divisibility.GetValueOrDefault(); }
                    set { __pbn__Divisibility = value; }
                }
                public bool ShouldSerializeDivisibility() => __pbn__Divisibility != null;
                public void ResetDivisibility() => __pbn__Divisibility = null;
                private uint? __pbn__Divisibility;

                [ProtoBuf.ProtoMember(6, Name = @"levy")]
                [System.ComponentModel.DefaultValue(NEMMosaicLevy.MosaicLevyAbsolute)]
                public NEMMosaicLevy Levy
                {
                    get { return __pbn__Levy ?? NEMMosaicLevy.MosaicLevyAbsolute; }
                    set { __pbn__Levy = value; }
                }
                public bool ShouldSerializeLevy() => __pbn__Levy != null;
                public void ResetLevy() => __pbn__Levy = null;
                private NEMMosaicLevy? __pbn__Levy;

                [ProtoBuf.ProtoMember(7, Name = @"fee")]
                public ulong Fee
                {
                    get { return __pbn__Fee.GetValueOrDefault(); }
                    set { __pbn__Fee = value; }
                }
                public bool ShouldSerializeFee() => __pbn__Fee != null;
                public void ResetFee() => __pbn__Fee = null;
                private ulong? __pbn__Fee;

                [ProtoBuf.ProtoMember(8, Name = @"levy_address")]
                [System.ComponentModel.DefaultValue("")]
                public string LevyAddress
                {
                    get { return __pbn__LevyAddress ?? ""; }
                    set { __pbn__LevyAddress = value; }
                }
                public bool ShouldSerializeLevyAddress() => __pbn__LevyAddress != null;
                public void ResetLevyAddress() => __pbn__LevyAddress = null;
                private string __pbn__LevyAddress;

                [ProtoBuf.ProtoMember(9, Name = @"levy_namespace")]
                [System.ComponentModel.DefaultValue("")]
                public string LevyNamespace
                {
                    get { return __pbn__LevyNamespace ?? ""; }
                    set { __pbn__LevyNamespace = value; }
                }
                public bool ShouldSerializeLevyNamespace() => __pbn__LevyNamespace != null;
                public void ResetLevyNamespace() => __pbn__LevyNamespace = null;
                private string __pbn__LevyNamespace;

                [ProtoBuf.ProtoMember(10, Name = @"levy_mosaic")]
                [System.ComponentModel.DefaultValue("")]
                public string LevyMosaic
                {
                    get { return __pbn__LevyMosaic ?? ""; }
                    set { __pbn__LevyMosaic = value; }
                }
                public bool ShouldSerializeLevyMosaic() => __pbn__LevyMosaic != null;
                public void ResetLevyMosaic() => __pbn__LevyMosaic = null;
                private string __pbn__LevyMosaic;

                [ProtoBuf.ProtoMember(11, Name = @"supply")]
                public ulong Supply
                {
                    get { return __pbn__Supply.GetValueOrDefault(); }
                    set { __pbn__Supply = value; }
                }
                public bool ShouldSerializeSupply() => __pbn__Supply != null;
                public void ResetSupply() => __pbn__Supply = null;
                private ulong? __pbn__Supply;

                [ProtoBuf.ProtoMember(12, Name = @"mutable_supply")]
                public bool MutableSupply
                {
                    get { return __pbn__MutableSupply.GetValueOrDefault(); }
                    set { __pbn__MutableSupply = value; }
                }
                public bool ShouldSerializeMutableSupply() => __pbn__MutableSupply != null;
                public void ResetMutableSupply() => __pbn__MutableSupply = null;
                private bool? __pbn__MutableSupply;

                [ProtoBuf.ProtoMember(13, Name = @"transferable")]
                public bool Transferable
                {
                    get { return __pbn__Transferable.GetValueOrDefault(); }
                    set { __pbn__Transferable = value; }
                }
                public bool ShouldSerializeTransferable() => __pbn__Transferable != null;
                public void ResetTransferable() => __pbn__Transferable = null;
                private bool? __pbn__Transferable;

                [ProtoBuf.ProtoMember(14, Name = @"description")]
                [System.ComponentModel.DefaultValue("")]
                public string Description
                {
                    get { return __pbn__Description ?? ""; }
                    set { __pbn__Description = value; }
                }
                public bool ShouldSerializeDescription() => __pbn__Description != null;
                public void ResetDescription() => __pbn__Description = null;
                private string __pbn__Description;

                [ProtoBuf.ProtoMember(15, Name = @"networks")]
                public uint[] Networks { get; set; }

                [ProtoBuf.ProtoContract()]
                public enum NEMMosaicLevy
                {
                    [ProtoBuf.ProtoEnum(Name = @"MosaicLevy_Absolute")]
                    MosaicLevyAbsolute = 1,
                    [ProtoBuf.ProtoEnum(Name = @"MosaicLevy_Percentile")]
                    MosaicLevyPercentile = 2,
                }

            }

        }

        [ProtoBuf.ProtoContract()]
        public class NEMMosaicSupplyChange : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"namespace")]
            [System.ComponentModel.DefaultValue("")]
            public string Namespace
            {
                get { return __pbn__Namespace ?? ""; }
                set { __pbn__Namespace = value; }
            }
            public bool ShouldSerializeNamespace() => __pbn__Namespace != null;
            public void ResetNamespace() => __pbn__Namespace = null;
            private string __pbn__Namespace;

            [ProtoBuf.ProtoMember(2, Name = @"mosaic")]
            [System.ComponentModel.DefaultValue("")]
            public string Mosaic
            {
                get { return __pbn__Mosaic ?? ""; }
                set { __pbn__Mosaic = value; }
            }
            public bool ShouldSerializeMosaic() => __pbn__Mosaic != null;
            public void ResetMosaic() => __pbn__Mosaic = null;
            private string __pbn__Mosaic;

            [ProtoBuf.ProtoMember(3, Name = @"type")]
            [System.ComponentModel.DefaultValue(NEMSupplyChangeType.SupplyChangeIncrease)]
            public NEMSupplyChangeType Type
            {
                get { return __pbn__Type ?? NEMSupplyChangeType.SupplyChangeIncrease; }
                set { __pbn__Type = value; }
            }
            public bool ShouldSerializeType() => __pbn__Type != null;
            public void ResetType() => __pbn__Type = null;
            private NEMSupplyChangeType? __pbn__Type;

            [ProtoBuf.ProtoMember(4, Name = @"delta")]
            public ulong Delta
            {
                get { return __pbn__Delta.GetValueOrDefault(); }
                set { __pbn__Delta = value; }
            }
            public bool ShouldSerializeDelta() => __pbn__Delta != null;
            public void ResetDelta() => __pbn__Delta = null;
            private ulong? __pbn__Delta;

            [ProtoBuf.ProtoContract()]
            public enum NEMSupplyChangeType
            {
                [ProtoBuf.ProtoEnum(Name = @"SupplyChange_Increase")]
                SupplyChangeIncrease = 1,
                [ProtoBuf.ProtoEnum(Name = @"SupplyChange_Decrease")]
                SupplyChangeDecrease = 2,
            }

        }

        [ProtoBuf.ProtoContract()]
        public class NEMAggregateModification : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"modifications")]
            public System.Collections.Generic.List<NEMCosignatoryModification> Modifications { get; } = new System.Collections.Generic.List<NEMCosignatoryModification>();

            [ProtoBuf.ProtoMember(2, Name = @"relative_change", DataFormat = ProtoBuf.DataFormat.ZigZag)]
            public int RelativeChange
            {
                get { return __pbn__RelativeChange.GetValueOrDefault(); }
                set { __pbn__RelativeChange = value; }
            }
            public bool ShouldSerializeRelativeChange() => __pbn__RelativeChange != null;
            public void ResetRelativeChange() => __pbn__RelativeChange = null;
            private int? __pbn__RelativeChange;

            [ProtoBuf.ProtoContract()]
            public class NEMCosignatoryModification : ProtoBuf.IExtensible
            {
                private ProtoBuf.IExtension __pbn__extensionData;
                ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [ProtoBuf.ProtoMember(1, Name = @"type")]
                [System.ComponentModel.DefaultValue(NEMModificationType.CosignatoryModificationAdd)]
                public NEMModificationType Type
                {
                    get { return __pbn__Type ?? NEMModificationType.CosignatoryModificationAdd; }
                    set { __pbn__Type = value; }
                }
                public bool ShouldSerializeType() => __pbn__Type != null;
                public void ResetType() => __pbn__Type = null;
                private NEMModificationType? __pbn__Type;

                [ProtoBuf.ProtoMember(2, Name = @"public_key")]
                public byte[] PublicKey
                {
                    get { return __pbn__PublicKey; }
                    set { __pbn__PublicKey = value; }
                }
                public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
                public void ResetPublicKey() => __pbn__PublicKey = null;
                private byte[] __pbn__PublicKey;

                [ProtoBuf.ProtoContract()]
                public enum NEMModificationType
                {
                    [ProtoBuf.ProtoEnum(Name = @"CosignatoryModification_Add")]
                    CosignatoryModificationAdd = 1,
                    [ProtoBuf.ProtoEnum(Name = @"CosignatoryModification_Delete")]
                    CosignatoryModificationDelete = 2,
                }

            }

        }

        [ProtoBuf.ProtoContract()]
        public class NEMImportanceTransfer : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"mode")]
            [System.ComponentModel.DefaultValue(NEMImportanceTransferMode.ImportanceTransferActivate)]
            public NEMImportanceTransferMode Mode
            {
                get { return __pbn__Mode ?? NEMImportanceTransferMode.ImportanceTransferActivate; }
                set { __pbn__Mode = value; }
            }
            public bool ShouldSerializeMode() => __pbn__Mode != null;
            public void ResetMode() => __pbn__Mode = null;
            private NEMImportanceTransferMode? __pbn__Mode;

            [ProtoBuf.ProtoMember(2, Name = @"public_key")]
            public byte[] PublicKey
            {
                get { return __pbn__PublicKey; }
                set { __pbn__PublicKey = value; }
            }
            public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
            public void ResetPublicKey() => __pbn__PublicKey = null;
            private byte[] __pbn__PublicKey;

            [ProtoBuf.ProtoContract()]
            public enum NEMImportanceTransferMode
            {
                [ProtoBuf.ProtoEnum(Name = @"ImportanceTransfer_Activate")]
                ImportanceTransferActivate = 1,
                [ProtoBuf.ProtoEnum(Name = @"ImportanceTransfer_Deactivate")]
                ImportanceTransferDeactivate = 2,
            }

        }

    }
}