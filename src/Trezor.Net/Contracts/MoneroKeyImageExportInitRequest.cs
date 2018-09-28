namespace Trezor.Net.Contracts.Monero
{
    [global::ProtoBuf.ProtoContract()]
    public class MoneroKeyImageExportInitRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"num")]
        public ulong Num
        {
            get { return __pbn__Num.GetValueOrDefault(); }
            set { __pbn__Num = value; }
        }
        public bool ShouldSerializeNum() => __pbn__Num != null;
        public void ResetNum() => __pbn__Num = null;
        private ulong? __pbn__Num;

        [global::ProtoBuf.ProtoMember(2, Name = @"hash")]
        public byte[] Hash
        {
            get { return __pbn__Hash; }
            set { __pbn__Hash = value; }
        }
        public bool ShouldSerializeHash() => __pbn__Hash != null;
        public void ResetHash() => __pbn__Hash = null;
        private byte[] __pbn__Hash;

        [global::ProtoBuf.ProtoMember(3, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"network_type")]
        public uint NetworkType
        {
            get { return __pbn__NetworkType.GetValueOrDefault(); }
            set { __pbn__NetworkType = value; }
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [global::ProtoBuf.ProtoMember(5, Name = @"subs")]
        public global::System.Collections.Generic.List<MoneroSubAddressIndicesList> Subs { get; } = new global::System.Collections.Generic.List<MoneroSubAddressIndicesList>();

        [global::ProtoBuf.ProtoContract()]
        public class MoneroSubAddressIndicesList : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"account")]
            public uint Account
            {
                get { return __pbn__Account.GetValueOrDefault(); }
                set { __pbn__Account = value; }
            }
            public bool ShouldSerializeAccount() => __pbn__Account != null;
            public void ResetAccount() => __pbn__Account = null;
            private uint? __pbn__Account;

            [global::ProtoBuf.ProtoMember(2, Name = @"minor_indices")]
            public uint[] MinorIndices { get; set; }

        }

    }
}