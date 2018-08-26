using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Trezor.Net.UWPUnitTest
{
    [TestClass]
    public partial class UnitTest
    {
        [TestMethod]
        public async Task GetAddress()
        {
            var trezorHidDevice = await Connect();
            string pin = await GetPin();
        }
    }
}
