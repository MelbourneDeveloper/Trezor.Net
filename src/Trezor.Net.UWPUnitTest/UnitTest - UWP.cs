using Hid.Net;
using Hid.Net.UWP;
using System.Threading.Tasks;
using Trezor.Net.UWPUnitTest;

namespace Trezor.Net
{
    public partial class UnitTestBase
    {
        private static async Task<string> GetPin()
        {
            var pinCompletionSource = new TaskCompletionSource<string>();
            App.PinSelected += (a, b) =>
            {
                pinCompletionSource.SetResult(App.Pin);
            };
            var pin = await pinCompletionSource.Task;
            return pin;
        }

        private static async Task<IHidDevice> Connect()
        {
            var taskCompletionSource = new TaskCompletionSource<IHidDevice>();
            var trezorHidDevice = new UWPHidDevice();
            var poller = new UWPHidDevicePoller(TrezorManager.TrezorProductId, TrezorManager.TrezorVendorId, trezorHidDevice);
            trezorHidDevice.Connected += (a, b) =>
            {
                poller.Stop();
                taskCompletionSource.SetResult(trezorHidDevice);
            };
            return await taskCompletionSource.Task;
        }

    }
}
