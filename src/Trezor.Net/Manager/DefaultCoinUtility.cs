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
                    return new CoinInfo(coinNumber, null, true, AddressType.Bitcoin);
                case 60:
                    return new CoinInfo(coinNumber, null, false, AddressType.Ethereum);
                case 61:
                    return new CoinInfo(coinNumber, null, false, AddressType.Ethereum);
                case 145:
                    return new CoinInfo(coinNumber, "Bcash", false, AddressType.Bitcoin);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
