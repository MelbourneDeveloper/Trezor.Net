namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroTransactionSignRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"init")]
        public MoneroTransactionInitRequest Init { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"set_input")]
        public MoneroTransactionSetInputRequest SetInput { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"input_permutation")]
        public MoneroTransactionInputsPermutationRequest InputPermutation { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"input_vini")]
        public MoneroTransactionInputViniRequest InputVini { get; set; }

        [ProtoBuf.ProtoMember(5, Name = @"all_in_set")]
        public MoneroTransactionAllInputsSetRequest AllInSet { get; set; }

        [ProtoBuf.ProtoMember(6, Name = @"set_output")]
        public MoneroTransactionSetOutputRequest SetOutput { get; set; }

        [ProtoBuf.ProtoMember(7, Name = @"rsig")]
        public MoneroTransactionRangeSigRequest Rsig { get; set; }

        [ProtoBuf.ProtoMember(8, Name = @"all_out_set")]
        public MoneroTransactionAllOutSetRequest AllOutSet { get; set; }

        [ProtoBuf.ProtoMember(9, Name = @"mlsag_done")]
        public MoneroTransactionMlsagDoneRequest MlsagDone { get; set; }

        [ProtoBuf.ProtoMember(10, Name = @"sign_input")]
        public MoneroTransactionSignInputRequest SignInput { get; set; }

        [ProtoBuf.ProtoMember(11, Name = @"final_msg")]
        public MoneroTransactionFinalRequest FinalMsg { get; set; }

    }
}