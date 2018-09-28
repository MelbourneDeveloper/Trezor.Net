namespace Trezor.Net.Contracts.Monero
{
    [ProtoBuf.ProtoContract()]
    public class MoneroKeyImageExportInitRequest : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"num")]
        public ulong Num
        {
            get => __pbn__Num.GetValueOrDefault();
            set => __pbn__Num = value;
        }
        public bool ShouldSerializeNum() => __pbn__Num != null;
        public void ResetNum() => __pbn__Num = null;
        private ulong? __pbn__Num;

        [ProtoBuf.ProtoMember(2, Name = @"hash")]
        public byte[] Hash { get; set; }
        public bool ShouldSerializeHash() => Hash != null;
        public void ResetHash() => Hash = null;

        [ProtoBuf.ProtoMember(3, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [ProtoBuf.ProtoMember(4, Name = @"network_type")]
        public uint NetworkType
        {
            get => __pbn__NetworkType.GetValueOrDefault();
            set => __pbn__NetworkType = value;
        }
        public bool ShouldSerializeNetworkType() => __pbn__NetworkType != null;
        public void ResetNetworkType() => __pbn__NetworkType = null;
        private uint? __pbn__NetworkType;

        [ProtoBuf.ProtoMember(5, Name = @"subs")]
        public System.Collections.Generic.List<MoneroSubAddressIndicesList> Subs { get; } = new System.Collections.Generic.List<MoneroSubAddressIndicesList>();

        [ProtoBuf.ProtoContract()]
        public class MoneroSubAddressIndicesList : ProtoBuf.IExtensible
        {
            private ProtoBuf.IExtension __pbn__extensionData;
            ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [ProtoBuf.ProtoMember(1, Name = @"account")]
            public uint Account
            {
                get => __pbn__Account.GetValueOrDefault();
                set => __pbn__Account = value;
            }
            public bool ShouldSerializeAccount() => __pbn__Account != null;
            public void ResetAccount() => __pbn__Account = null;
            private uint? __pbn__Account;

            [ProtoBuf.ProtoMember(2, Name = @"minor_indices")]
            public uint[] MinorIndices { get; set; }

        }

    }
}