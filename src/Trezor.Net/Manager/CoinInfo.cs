namespace Trezor.Net
{
    public class CoinInfo
    {
        public string CoinName { get; set; }
        public AddressType AddressType { get; set; }

        public CoinInfo(string coinName, AddressType addressType)
        {
            CoinName = coinName;
            AddressType = addressType;
        }
    }
}
