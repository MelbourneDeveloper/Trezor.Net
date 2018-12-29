using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            //Register the factory for creating Usb devices. This only needs to be done once.
            WindowsUsbDeviceFactory.Register();
            WindowsHidDeviceFactory.Register();

            //Get the first available device and connect to it
            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            return devices.FirstOrDefault();
        }
    }
}
