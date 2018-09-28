namespace Trezor.Net
{
    public class CoinInfo
    {
        public string CoinName { get; }
        public uint CoinNumber { get;  }
        public bool IsSegwit { get;  }
        public AddressType AddressType { get;  }

        public CoinInfo(uint coinNumber, string coinName, bool isSegwit, AddressType addressType)
        {
            CoinName = coinName;
            CoinNumber = coinNumber;
            IsSegwit = isSegwit;
            AddressType = addressType;
        }
    }
}
