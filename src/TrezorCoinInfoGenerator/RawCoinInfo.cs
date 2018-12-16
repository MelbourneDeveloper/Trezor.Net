using System.Collections.Generic;

namespace TrezorCoinInfoGenerator
{
    public class DefaultFeeB
    {
        public int Low { get; set; }
        public int Economy { get; set; }
        public int Normal { get; set; }
        public int High { get; set; }
    }

    public class RawCoinInfo
    {
        public string coin_name { get; set; }
        public string coin_shortcut { get; set; }
        public string coin_label { get; set; }
        public string website { get; set; }
        public string github { get; set; }
        public string maintainer { get; set; }
        public string curve_name { get; set; }
        public int address_type { get; set; }
        public int address_type_p2sh { get; set; }
        public int maxfee_kb { get; set; }
        public int minfee_kb { get; set; }
        public string signed_message_header { get; set; }
        public string hash_genesis_block { get; set; }
        public int xprv_magic { get; set; }
        public int xpub_magic { get; set; }
        public object xpub_magic_segwit_p2sh { get; set; }
        public object xpub_magic_segwit_native { get; set; }
        public object bech32_prefix { get; set; }
        public string cashaddr_prefix { get; set; }
        public uint slip44 { get; set; }
        public bool segwit { get; set; }
        public bool decred { get; set; }
        public int? fork_id { get; set; }
        public bool force_bip143 { get; set; }
        public bool bip115 { get; set; }
        public object version_group_id { get; set; }
        public DefaultFeeB default_fee_b { get; set; }
        public int dust_limit { get; set; }
        public int blocktime_seconds { get; set; }
        public string uri_prefix { get; set; }
        public int min_address_length { get; set; }
        public int max_address_length { get; set; }
        public List<object> bitcore { get; set; }
        public List<string> blockbook { get; set; }
        public int cooldown { get; set; }
    }
}
