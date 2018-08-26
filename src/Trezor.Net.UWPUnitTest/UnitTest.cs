using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Trezor.Net.UWPUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task GetPin()
        {
            var pinCompletionSource = new TaskCompletionSource<string>();
            App.PinSelected += (a, b) =>
            {
                pinCompletionSource.SetResult(App.Pin);
            };
            var pin = await pinCompletionSource.Task;
            System.Diagnostics.Debug.WriteLine(pin);
        }
    }
}
