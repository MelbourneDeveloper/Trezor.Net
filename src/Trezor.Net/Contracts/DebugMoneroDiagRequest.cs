namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class DebugMoneroDiagRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ins")]
        public ulong Ins
        {
            get { return __pbn__Ins.GetValueOrDefault(); }
            set { __pbn__Ins = value; }
        }
        public bool ShouldSerializeIns() => __pbn__Ins != null;
        public void ResetIns() => __pbn__Ins = null;
        private ulong? __pbn__Ins;

        [global::ProtoBuf.ProtoMember(2, Name = @"p1")]
        public ulong P1
        {
            get { return __pbn__P1.GetValueOrDefault(); }
            set { __pbn__P1 = value; }
        }
        public bool ShouldSerializeP1() => __pbn__P1 != null;
        public void ResetP1() => __pbn__P1 = null;
        private ulong? __pbn__P1;

        [global::ProtoBuf.ProtoMember(3, Name = @"p2")]
        public ulong P2
        {
            get { return __pbn__P2.GetValueOrDefault(); }
            set { __pbn__P2 = value; }
        }
        public bool ShouldSerializeP2() => __pbn__P2 != null;
        public void ResetP2() => __pbn__P2 = null;
        private ulong? __pbn__P2;

        [global::ProtoBuf.ProtoMember(4, Name = @"pd")]
        public ulong[] Pds { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"data1")]
        public byte[] Data1
        {
            get { return __pbn__Data1; }
            set { __pbn__Data1 = value; }
        }
        public bool ShouldSerializeData1() => __pbn__Data1 != null;
        public void ResetData1() => __pbn__Data1 = null;
        private byte[] __pbn__Data1;

        [global::ProtoBuf.ProtoMember(6, Name = @"data2")]
        public byte[] Data2
        {
            get { return __pbn__Data2; }
            set { __pbn__Data2 = value; }
        }
        public bool ShouldSerializeData2() => __pbn__Data2 != null;
        public void ResetData2() => __pbn__Data2 = null;
        private byte[] __pbn__Data2;

    }
}