namespace Trezor.Net
{
    public class CoinInfo
    {
        public string CoinName { get; set; }
        public AddressType AddressType { get; set; }
        public bool IsSegwit { get; }

        public CoinInfo(string coinName, AddressType addressType, bool isSegwit)
        {
            CoinName = coinName;
            AddressType = addressType;
            IsSegwit = isSegwit;
        }
    }
}
