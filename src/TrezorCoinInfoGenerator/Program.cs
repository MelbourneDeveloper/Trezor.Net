using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Trezor.Net;

namespace TrezorCoinInfoGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var coinInfos = new List<CoinInfo>();

            foreach (var fileName in Directory.GetFiles(@"C:\GitRepos\trezor-mcu\vendor\trezor-common\defs\bitcoin").Where(f => Path.GetExtension(f).ToLower() == ".json"))
            {
                var text = File.ReadAllText(fileName);
                var coinInfo = JsonConvert.DeserializeObject<RawCoinInfo>(text);
                coinInfos.Add(new CoinInfo(coinInfo.coin_name, AddressType.Bitcoin, coinInfo.segwit, coinInfo.slip44));
            }

            File.WriteAllText("Coins.json", JsonConvert.SerializeObject(coinInfos));
        }
    }
}
