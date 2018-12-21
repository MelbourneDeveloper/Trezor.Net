using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsTrezorOneOldTests : WindowsTestBase
    {
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
                            trezorHidDevice = new WindowsHidDevice(trezorDeviceDefinition);
                            break;
                        case DeviceType.Usb:
                            trezorHidDevice = new WindowsUsbDevice(trezorDeviceDefinition.DeviceId, 64, 64);
                            break;
                    }
                    await trezorHidDevice.InitializeAsync();
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
