using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    [ProtoContract]
    public class CoinType
    {
        [ProtoMember(1, Name = @"coin_name")]
        [DefaultValue("")]
        public string CoinName
        {
            get => __pbn__CoinName ?? "";
            set => __pbn__CoinName = value;
        }
        public bool ShouldSerializeCoinName() => __pbn__CoinName != null;
        public void ResetCoinName() => __pbn__CoinName = null;
        private string __pbn__CoinName;

        [ProtoMember(2, Name = @"coin_shortcut")]
        [DefaultValue("")]
        public string CoinShortcut
        {
            get => __pbn__CoinShortcut ?? "";
            set => __pbn__CoinShortcut = value;
        }
        public bool ShouldSerializeCoinShortcut() => __pbn__CoinShortcut != null;
        public void ResetCoinShortcut() => __pbn__CoinShortcut = null;
        private string __pbn__CoinShortcut;

        [ProtoMember(3, Name = @"address_type")]
        [DefaultValue(0)]
        public uint AddressType
        {
            get => __pbn__AddressType ?? 0;
            set => __pbn__AddressType = value;
        }
        public bool ShouldSerializeAddressType() => __pbn__AddressType != null;
        public void ResetAddressType() => __pbn__AddressType = null;
        private uint? __pbn__AddressType;

        [ProtoMember(4, Name = @"maxfee_kb")]
        public ulong MaxfeeKb
        {
            get => __pbn__MaxfeeKb.GetValueOrDefault();
            set => __pbn__MaxfeeKb = value;
        }
        public bool ShouldSerializeMaxfeeKb() => __pbn__MaxfeeKb != null;
        public void ResetMaxfeeKb() => __pbn__MaxfeeKb = null;
        private ulong? __pbn__MaxfeeKb;

        [ProtoMember(5, Name = @"address_type_p2sh")]
        [DefaultValue(5)]
        public uint AddressTypeP2sh
        {
            get => __pbn__AddressTypeP2sh ?? 5;
            set => __pbn__AddressTypeP2sh = value;
        }
        public bool ShouldSerializeAddressTypeP2sh() => __pbn__AddressTypeP2sh != null;
        public void ResetAddressTypeP2sh() => __pbn__AddressTypeP2sh = null;
        private uint? __pbn__AddressTypeP2sh;

        [ProtoMember(8, Name = @"signed_message_header")]
        [DefaultValue("")]
        public string SignedMessageHeader
        {
            get => __pbn__SignedMessageHeader ?? "";
            set => __pbn__SignedMessageHeader = value;
        }
        public bool ShouldSerializeSignedMessageHeader() => __pbn__SignedMessageHeader != null;
        public void ResetSignedMessageHeader() => __pbn__SignedMessageHeader = null;
        private string __pbn__SignedMessageHeader;

        [ProtoMember(9, Name = @"xpub_magic")]
        [DefaultValue(76067358)]
        public uint XpubMagic
        {
            get => __pbn__XpubMagic ?? 76067358;
            set => __pbn__XpubMagic = value;
        }
        public bool ShouldSerializeXpubMagic() => __pbn__XpubMagic != null;
        public void ResetXpubMagic() => __pbn__XpubMagic = null;
        private uint? __pbn__XpubMagic;

        [ProtoMember(10, Name = @"xprv_magic")]
        [DefaultValue(76066276)]
        public uint XprvMagic
        {
            get => __pbn__XprvMagic ?? 76066276;
            set => __pbn__XprvMagic = value;
        }
        public bool ShouldSerializeXprvMagic() => __pbn__XprvMagic != null;
        public void ResetXprvMagic() => __pbn__XprvMagic = null;
        private uint? __pbn__XprvMagic;

        [ProtoMember(11, Name = @"segwit")]
        public bool Segwit
        {
            get => __pbn__Segwit.GetValueOrDefault();
            set => __pbn__Segwit = value;
        }
        public bool ShouldSerializeSegwit() => __pbn__Segwit != null;
        public void ResetSegwit() => __pbn__Segwit = null;
        private bool? __pbn__Segwit;

        [ProtoMember(12, Name = @"forkid")]
        public uint Forkid
        {
            get => __pbn__Forkid.GetValueOrDefault();
            set => __pbn__Forkid = value;
        }
        public bool ShouldSerializeForkid() => __pbn__Forkid != null;
        public void ResetForkid() => __pbn__Forkid = null;
        private uint? __pbn__Forkid;

        [ProtoMember(13, Name = @"force_bip143")]
        public bool ForceBip143
        {
            get => __pbn__ForceBip143.GetValueOrDefault();
            set => __pbn__ForceBip143 = value;
        }
        public bool ShouldSerializeForceBip143() => __pbn__ForceBip143 != null;
        public void ResetForceBip143() => __pbn__ForceBip143 = null;
        private bool? __pbn__ForceBip143;

    }
}