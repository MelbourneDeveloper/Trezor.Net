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
                    return new CoinInfo(coinNumber, "Bitcoin", true, AddressType.Bitcoin);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
