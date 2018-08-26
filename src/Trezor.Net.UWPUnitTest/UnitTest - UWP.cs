using Hid.Net;
using Hid.Net.UWP;
using System.Threading.Tasks;

namespace Trezor.Net.UWPUnitTest
{
    public partial class UnitTest
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
            new UWPHidDevicePoller(TrezorManager.TrezorProductId, TrezorManager.TrezorVendorId, trezorHidDevice);
            trezorHidDevice.Connected += (a, b) => taskCompletionSource.SetResult(trezorHidDevice);
            return await taskCompletionSource.Task;
        }

    }
}
