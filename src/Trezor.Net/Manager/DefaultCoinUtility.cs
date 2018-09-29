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
                    return new CoinInfo(null, AddressType.Bitcoin);
                case 60:
                    return new CoinInfo(null, AddressType.Ethereum);
                case 61:
                    return new CoinInfo(null, AddressType.Ethereum);
                case 145:
                    return new CoinInfo("Bcash", AddressType.Bitcoin);
                default:
                    throw new NotImplementedException($"The coin number {coinNumber} has not been filled in for {nameof(DefaultCoinUtility)}. Please create a class that implements ICoinUtility, or call an overload that specifies coin information.");
            }
        }
    }
}
