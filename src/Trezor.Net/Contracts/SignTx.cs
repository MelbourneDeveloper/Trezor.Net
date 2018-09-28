namespace Trezor.Net.Contracts.Bitcoin
{
    [ProtoBuf.ProtoContract()]
    public class SignTx : ProtoBuf.IExtensible
    {
        private ProtoBuf.IExtension __pbn__extensionData;
        ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [ProtoBuf.ProtoMember(1, Name = @"outputs_count", IsRequired = true)]
        public uint OutputsCount { get; set; }

        [ProtoBuf.ProtoMember(2, Name = @"inputs_count", IsRequired = true)]
        public uint InputsCount { get; set; }

        [ProtoBuf.ProtoMember(3, Name = @"coin_name")]
        [System.ComponentModel.DefaultValue(@"Bitcoin")]
        public string CoinName
        {
            get { return __pbn__CoinName ?? @"Bitcoin"; }
            set { __pbn__CoinName = value; }
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [ProtoBuf.ProtoMember(4, Name = @"version")]
        [System.ComponentModel.DefaultValue(1)]
        public uint Version
        {
            get { return __pbn__Version ?? 1; }
            set { __pbn__Version = value; }
        }
        public bool ShouldSerializeVersion() => __pbn__Version != null;
        public void ResetVersion() => __pbn__Version = null;
        private uint? __pbn__Version;

        [ProtoBuf.ProtoMember(5, Name = @"lock_time")]
        [System.ComponentModel.DefaultValue(0)]
        public uint LockTime
        {
            get { return __pbn__LockTime ?? 0; }
            set { __pbn__LockTime = value; }
        }
        public bool ShouldSerializeLockTime() => __pbn__LockTime != null;
        public void ResetLockTime() => __pbn__LockTime = null;
        private uint? __pbn__LockTime;

        [ProtoBuf.ProtoMember(6, Name = @"expiry")]
        public uint Expiry
        {
            get { return __pbn__Expiry.GetValueOrDefault(); }
            set { __pbn__Expiry = value; }
        }
        public bool ShouldSerializeExpiry() => __pbn__Expiry != null;
        public void ResetExpiry() => __pbn__Expiry = null;
        private uint? __pbn__Expiry;

        [ProtoBuf.ProtoMember(7, Name = @"overwintered")]
        public bool Overwintered
        {
            get { return __pbn__Overwintered.GetValueOrDefault(); }
            set { __pbn__Overwintered = value; }
        }
        public bool ShouldSerializeOverwintered() => __pbn__Overwintered != null;
        public void ResetOverwintered() => __pbn__Overwintered = null;
        private bool? __pbn__Overwintered;

    }
}