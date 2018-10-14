namespace Trezor.Net
{
    public class CoinInfo
    {
        public uint CoinType { get; set; }
        public string CoinName { get; set; }
        public AddressType AddressType { get; set; }
        public bool IsSegwit { get; }

        public CoinInfo(string coinName, AddressType addressType, bool isSegwit, uint cointType)
        {
            CoinName = coinName;
            AddressType = addressType;
            IsSegwit = isSegwit;
            CoinType = cointType;
        }
    }
}
