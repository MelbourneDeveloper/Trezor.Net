namespace Trezor.Net
{
    public class CoinInfo
    {
        public string CoinName { get; }
        public uint CoinNumber { get;  }
        public AddressType AddressType { get;  }

        public CoinInfo(uint coinNumber, string coinName, AddressType addressType)
        {
            CoinName = coinName;
            CoinNumber = coinNumber;
            AddressType = addressType;
        }
    }
}
