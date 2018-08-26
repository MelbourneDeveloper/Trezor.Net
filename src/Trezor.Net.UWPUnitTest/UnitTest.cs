using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public partial class UnitTest
    {
        private static TrezorManager TrezorManager;

        [TestMethod]
        public async Task GetAddress()
        {
            await GetAndInitialize();
            var address = await TrezorManager.GetAddressAsync("BTC", 0, false, 0, true, AddressType.Bitcoin);
        }

        private async Task GetAndInitialize()
        {
            if (TrezorManager != null)
            {
                return;
            }

            var trezorHidDevice = await Connect();
            TrezorManager = new TrezorManager(GetPin, trezorHidDevice);
            await TrezorManager.InitializeAsync();
        }
    }
}
