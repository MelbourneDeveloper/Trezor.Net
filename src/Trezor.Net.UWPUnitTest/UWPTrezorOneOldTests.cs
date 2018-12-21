using Device.Net;
using Device.Net.UWP;
using Hid.Net.UWP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Trezor.Net.UWPUnitTest;

namespace Trezor.Net
{
    [TestClass]
    public class UWPTrezorOneOldTests : UnitTestBase
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

        protected override async Task<IDevice> Connect()
        {
            var taskCompletionSource = new TaskCompletionSource<IDevice>();
            var trezorHidDevice = new UWPHidDevice();
            var poller = new UWPDevicePoller(TrezorManager.TrezorProductId, TrezorManager.TrezorVendorId, DeviceType.Hid , trezorHidDevice);
            trezorHidDevice.Connected += (a, b) =>
            {
                poller.Stop();
                taskCompletionSource.SetResult(trezorHidDevice);
            };
            return await taskCompletionSource.Task;
        }

    }
}
