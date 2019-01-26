using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using Trezor.Net.Manager;
using Usb.Net.Windows;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsTests : WindowsTestBase
    {
        private static TrezorManagerBroker _TrezorManagerBroker;

        protected override async Task<TrezorManager> Connect()
        {
            //This only needs to be done once.
            //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x / Trezor Model T
            WindowsUsbDeviceFactory.Register();
            //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
            WindowsHidDeviceFactory.Register();

            _TrezorManagerBroker = new TrezorManagerBroker(GetPin, 2000);
            return await _TrezorManagerBroker.WaitForFirstTrezorAsync();
        }
    }
}
