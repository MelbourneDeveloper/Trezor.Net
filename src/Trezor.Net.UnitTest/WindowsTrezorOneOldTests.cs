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
            WindowsHidDeviceFactory.Register();
            //WindowsUsbDeviceFactory.Register();

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
