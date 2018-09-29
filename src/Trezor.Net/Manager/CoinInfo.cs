namespace Trezor.Net
{
    public class CoinInfo
    {
        public string CoinName { get; }
        public AddressType AddressType { get;  }

        public CoinInfo(string coinName, AddressType addressType)
        {
            CoinName = coinName;
            AddressType = addressType;
        }
    }
}
