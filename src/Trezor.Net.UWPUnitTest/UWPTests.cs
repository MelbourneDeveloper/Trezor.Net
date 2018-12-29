using Device.Net;
using Hid.Net.UWP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
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

        protected override async Task<IDevice> Connect()
        {
            UWPUsbDeviceFactory.Register();
            UWPHidDeviceFactory.Register();

            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            var trezorDevice = devices.FirstOrDefault();
            await trezorDevice.InitializeAsync();

            if (trezorDevice == null)
            {
                throw new System.Exception("No Trezor was connected");
            }

            return trezorDevice;
        }
    }
}
