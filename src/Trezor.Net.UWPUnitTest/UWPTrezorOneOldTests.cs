using Device.Net;
using Device.Net.UWP;
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
            DeviceDefinition trezorDeviceDefinition;
            IDevice trezorHidDevice = null;

            foreach (var deviceDefinition in TrezorManager.DeviceDefinitions)
            {
                var definitions = await DeviceManager.Current.GetConnectedDeviceDefinitions(deviceDefinition.VendorId, deviceDefinition.ProductId, deviceDefinition.DeviceType);
                trezorDeviceDefinition = definitions.FirstOrDefault();
                if (trezorDeviceDefinition != null)
                {
                    switch (trezorDeviceDefinition.DeviceType)
                    {
                        case DeviceType.Hid:
                            trezorHidDevice = new UWPHidDevice(trezorDeviceDefinition.DeviceId);
                            break;
                        case DeviceType.Usb:
                            trezorHidDevice = new UWPUsbDevice(trezorDeviceDefinition.DeviceId);
                            break;
                    }
                    break;
                }
            }

            if (trezorHidDevice == null)
            {
                throw new System.Exception("No Trezor was connected");
            }

            return trezorHidDevice;
        }
    }
}
