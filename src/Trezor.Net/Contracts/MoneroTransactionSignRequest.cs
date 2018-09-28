namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroTransactionSignRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"init")]
        public MoneroTransactionInitRequest Init { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"set_input")]
        public MoneroTransactionSetInputRequest SetInput { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"input_permutation")]
        public MoneroTransactionInputsPermutationRequest InputPermutation { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"input_vini")]
        public MoneroTransactionInputViniRequest InputVini { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"all_in_set")]
        public MoneroTransactionAllInputsSetRequest AllInSet { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"set_output")]
        public MoneroTransactionSetOutputRequest SetOutput { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"rsig")]
        public MoneroTransactionRangeSigRequest Rsig { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"all_out_set")]
        public MoneroTransactionAllOutSetRequest AllOutSet { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"mlsag_done")]
        public MoneroTransactionMlsagDoneRequest MlsagDone { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"sign_input")]
        public MoneroTransactionSignInputRequest SignInput { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"final_msg")]
        public MoneroTransactionFinalRequest FinalMsg { get; set; }

    }
}