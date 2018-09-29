using System;

namespace Trezor.Net
{
    public class DefaultCoinUtility : ICoinUtility
    {
        public CoinInfo GetCoinInfo(uint coinNumber)
        {
            switch (coinNumber)
            {
                case 0:
                    return new CoinInfo(coinNumber, null, AddressType.Bitcoin);
                case 60:
                    return new CoinInfo(coinNumber, null, AddressType.Ethereum);
                case 61:
                    return new CoinInfo(coinNumber, null, AddressType.Ethereum);
                case 145:
                    return new CoinInfo(coinNumber, "Bcash", AddressType.Bitcoin);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
