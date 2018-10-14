using System;
using System.IO;
using System.Reflection;

namespace Trezor.Net
{
    public class DefaultCoinUtility : ICoinUtility
    {
        public DefaultCoinUtility()
        {
            //var assembly = typeof(TrezorManager).GetTypeInfo().Assembly;
            //var stream = assembly.GetManifestResourceStream("Trezor.Net.Resources.Coins.json");
            //string json;
            //using (var reader = new StreamReader(stream))
            //{
            //    json = reader.ReadToEnd();
            //}
            //return json;
        }

        public CoinInfo GetCoinInfo(uint coinNumber)
        {
            switch (coinNumber)
            {
                case 0:
                    return new CoinInfo(null, AddressType.Bitcoin, true, coinNumber);
                case 60:
                    return new CoinInfo(null, AddressType.Ethereum, false, coinNumber);
                case 61:
                    return new CoinInfo(null, AddressType.Ethereum, false, coinNumber);
                case 145:
                    return new CoinInfo("Bcash", AddressType.Bitcoin, true, coinNumber);
                default:
                    throw new NotImplementedException($"The coin number {coinNumber} has not been filled in for {nameof(DefaultCoinUtility)}. Please create a class that implements ICoinUtility, or call an overload that specifies coin information.");
            }
        }
    }
}
