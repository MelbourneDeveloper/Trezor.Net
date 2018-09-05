using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMSignTx
    {
        [ProtoMember(1, Name = @"transaction")]
        public NEMTransactionCommon Transaction { get; set; }

        [ProtoMember(2, Name = @"multisig")]
        public NEMTransactionCommon Multisig { get; set; }

        [ProtoMember(3, Name = @"transfer")]
        public NEMTransfer Transfer { get; set; }

        [ProtoMember(4, Name = @"cosigning")]
        public bool Cosigning
        {
            get => __pbn__Cosigning.GetValueOrDefault();
            set => __pbn__Cosigning = value;
        }
        public bool ShouldSerializeCosigning() => __pbn__Cosigning != null;
        public void ResetCosigning() => __pbn__Cosigning = null;
        private bool? __pbn__Cosigning;

        [ProtoMember(5, Name = @"provision_namespace")]
        public NEMProvisionNamespace ProvisionNamespace { get; set; }

        [ProtoMember(6, Name = @"mosaic_creation")]
        public NEMMosaicCreation MosaicCreation { get; set; }

        [ProtoMember(7, Name = @"supply_change")]
        public NEMMosaicSupplyChange SupplyChange { get; set; }

        [ProtoMember(8, Name = @"aggregate_modification")]
        public NEMAggregateModification AggregateModification { get; set; }

        [ProtoMember(9, Name = @"importance_transfer")]
        public NEMImportanceTransfer ImportanceTransfer { get; set; }

    }
}