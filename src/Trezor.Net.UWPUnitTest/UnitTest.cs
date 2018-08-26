using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public partial class UnitTest
    {
        [TestMethod]
        public async Task GetAddress()
        {
            var trezorHidDevice = await Connect();
            var trezorManager = new TrezorManager(GetPin, trezorHidDevice);
            await trezorManager.InitializeAsync();
            var address = await trezorManager.GetAddressAsync("BTC", 0, false, 0, true, AddressType.Bitcoin);
        }
    }
}
