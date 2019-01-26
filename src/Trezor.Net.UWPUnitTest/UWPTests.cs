using Hid.Net.UWP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Trezor.Net.UWPUnitTest;
using Usb.Net.UWP;

namespace Trezor.Net
{
    [TestClass]
    public class UWPTests : UnitTestBase
    {
        protected override async Task<string> GetPin()
        {
            var pinCompletionSource = new TaskCompletionSource<string>();
            App.PinSelected += (a, b) =>
            {
                pinCompletionSource.SetResult(App.Pin);
            };
            var pin = await pinCompletionSource.Task;
            return pin;
        }

        protected override Task<TrezorManager> ConnectAsync()
        {
            UWPUsbDeviceFactory.Register();
            UWPHidDeviceFactory.Register();

            return base.ConnectAsync();
        }
    }
}
