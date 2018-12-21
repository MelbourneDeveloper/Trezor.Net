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
    public class UWPTrezorOneOldTests : UnitTestBase
    {
        static UWPTrezorOneOldTests()
        {
            UWPUsbDeviceFactory.Register();
            UWPHidDeviceFactory.Register();
        }

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
            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            var trezorDevice = devices.FirstOrDefault();

            if (trezorDevice == null)
            {
                throw new System.Exception("No Trezor was connected");
            }

            await trezorDevice.InitializeAsync();

            return trezorDevice;
        }
    }
}
