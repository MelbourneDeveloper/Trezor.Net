namespace Trezor.Net.Contracts.Lisk
{
    [global::ProtoBuf.ProtoContract()]
    public class LiskSignTx : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"transaction")]
        public LiskTransactionCommon Transaction { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public class LiskTransactionCommon : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"type")]
            [global::System.ComponentModel.DefaultValue(LiskTransactionType.Transfer)]
            public LiskTransactionType Type
            {
                get { return __pbn__Type ?? LiskTransactionType.Transfer; }
                set { __pbn__Type = value; }
            }
            public bool ShouldSerializeType() => __pbn__Type != null;
            public void ResetType() => __pbn__Type = null;
            private LiskTransactionType? __pbn__Type;

            [global::ProtoBuf.ProtoMember(2, Name = @"amount")]
            [global::System.ComponentModel.DefaultValue(0)]
            public ulong Amount
            {
                get { return __pbn__Amount ?? 0; }
                set { __pbn__Amount = value; }
            }
            public bool ShouldSerializeAmount() => __pbn__Amount != null;
            public void ResetAmount() => __pbn__Amount = null;
            private ulong? __pbn__Amount;

            [global::ProtoBuf.ProtoMember(3, Name = @"fee")]
            public ulong Fee
            {
                get { return __pbn__Fee.GetValueOrDefault(); }
                set { __pbn__Fee = value; }
            }
            public bool ShouldSerializeFee() => __pbn__Fee != null;
            public void ResetFee() => __pbn__Fee = null;
            private ulong? __pbn__Fee;

            [global::ProtoBuf.ProtoMember(4, Name = @"recipient_id")]
            [global::System.ComponentModel.DefaultValue("")]
            public string RecipientId
            {
                get { return __pbn__RecipientId ?? ""; }
                set { __pbn__RecipientId = value; }
            }
            public bool ShouldSerializeRecipientId() => __pbn__RecipientId != null;
            public void ResetRecipientId() => __pbn__RecipientId = null;
            private string __pbn__RecipientId;

            [global::ProtoBuf.ProtoMember(5, Name = @"sender_public_key")]
            public byte[] SenderPublicKey
            {
                get { return __pbn__SenderPublicKey; }
                set { __pbn__SenderPublicKey = value; }
            }
            public bool ShouldSerializeSenderPublicKey() => __pbn__SenderPublicKey != null;
            public void ResetSenderPublicKey() => __pbn__SenderPublicKey = null;
            private byte[] __pbn__SenderPublicKey;

            [global::ProtoBuf.ProtoMember(6, Name = @"requester_public_key")]
            public byte[] RequesterPublicKey
            {
                get { return __pbn__RequesterPublicKey; }
                set { __pbn__RequesterPublicKey = value; }
            }
            public bool ShouldSerializeRequesterPublicKey() => __pbn__RequesterPublicKey != null;
            public void ResetRequesterPublicKey() => __pbn__RequesterPublicKey = null;
            private byte[] __pbn__RequesterPublicKey;

            [global::ProtoBuf.ProtoMember(7, Name = @"signature")]
            public byte[] Signature
            {
                get { return __pbn__Signature; }
                set { __pbn__Signature = value; }
            }
            public bool ShouldSerializeSignature() => __pbn__Signature != null;
            public void ResetSignature() => __pbn__Signature = null;
            private byte[] __pbn__Signature;

            [global::ProtoBuf.ProtoMember(8, Name = @"timestamp")]
            public uint Timestamp
            {
                get { return __pbn__Timestamp.GetValueOrDefault(); }
                set { __pbn__Timestamp = value; }
            }
            public bool ShouldSerializeTimestamp() => __pbn__Timestamp != null;
            public void ResetTimestamp() => __pbn__Timestamp = null;
            private uint? __pbn__Timestamp;

            [global::ProtoBuf.ProtoMember(9, Name = @"asset")]
            public LiskTransactionAsset Asset { get; set; }

            [global::ProtoBuf.ProtoContract()]
            public class LiskTransactionAsset : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
                public LiskSignatureType Signature { get; set; }

                [global::ProtoBuf.ProtoMember(2, Name = @"delegate")]
                public LiskDelegateType Delegate { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"votes")]
                public global::System.Collections.Generic.List<string> Votes { get; } = new global::System.Collections.Generic.List<string>();

                [global::ProtoBuf.ProtoMember(4, Name = @"multisignature")]
                public LiskMultisignatureType Multisignature { get; set; }

                [global::ProtoBuf.ProtoMember(5, Name = @"data")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Data
                {
                    get { return __pbn__Data ?? ""; }
                    set { __pbn__Data = value; }
                }
                public bool ShouldSerializeData() => __pbn__Data != null;
                public void ResetData() => __pbn__Data = null;
                private string __pbn__Data;

                [global::ProtoBuf.ProtoContract()]
                public class LiskSignatureType : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"public_key")]
                    public byte[] PublicKey
                    {
                        get { return __pbn__PublicKey; }
                        set { __pbn__PublicKey = value; }
                    }
                    public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
                    public void ResetPublicKey() => __pbn__PublicKey = null;
                    private byte[] __pbn__PublicKey;

                }

                [global::ProtoBuf.ProtoContract()]
                public class LiskDelegateType : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"username")]
                    [global::System.ComponentModel.DefaultValue("")]
                    public string Username
                    {
                        get { return __pbn__Username ?? ""; }
                        set { __pbn__Username = value; }
                    }
                    public bool ShouldSerializeUsername() => __pbn__Username != null;
                    public void ResetUsername() => __pbn__Username = null;
                    private string __pbn__Username;

                }

                [global::ProtoBuf.ProtoContract()]
                public class LiskMultisignatureType : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"min")]
                    public uint Min
                    {
                        get { return __pbn__Min.GetValueOrDefault(); }
                        set { __pbn__Min = value; }
                    }
                    public bool ShouldSerializeMin() => __pbn__Min != null;
                    public void ResetMin() => __pbn__Min = null;
                    private uint? __pbn__Min;

                    [global::ProtoBuf.ProtoMember(2, Name = @"life_time")]
                    public uint LifeTime
                    {
                        get { return __pbn__LifeTime.GetValueOrDefault(); }
                        set { __pbn__LifeTime = value; }
                    }
                    public bool ShouldSerializeLifeTime() => __pbn__LifeTime != null;
                    public void ResetLifeTime() => __pbn__LifeTime = null;
                    private uint? __pbn__LifeTime;

                    [global::ProtoBuf.ProtoMember(3, Name = @"keys_group")]
                    public global::System.Collections.Generic.List<string> KeysGroups { get; } = new global::System.Collections.Generic.List<string>();

                }

            }

            [global::ProtoBuf.ProtoContract()]
            public enum LiskTransactionType
            {
                Transfer = 0,
                RegisterSecondPassphrase = 1,
                RegisterDelegate = 2,
                CastVotes = 3,
                RegisterMultisignatureAccount = 4,
                CreateDapp = 5,
                TransferIntoDapp = 6,
                TransferOutOfDapp = 7,
            }

        }

    }
}