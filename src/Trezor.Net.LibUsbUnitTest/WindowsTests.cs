using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using Usb.Net.Windows;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsTests : WindowsTestBase
    {
        protected override async Task<IDevice> Connect()
        {
            //This only needs to be done once.
            //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x / Trezor Model T
            WindowsUsbDeviceFactory.Register();
            //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
            WindowsHidDeviceFactory.Register();

            //Get the first available device and connect to it
            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            var trezorDevice = devices.FirstOrDefault();

            if (trezorDevice == null)
            {
                throw new Exception("No trezor connected");
            }

            await trezorDevice.InitializeAsync();

            return trezorDevice;
        }
    }
}
