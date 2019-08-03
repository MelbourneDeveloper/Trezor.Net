using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Usb.Net.Windows;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsTests : WindowsTestBase
    {

        protected override Task<TrezorManager> ConnectAsync()
        {
            //This only needs to be done once.
            //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x / Trezor Model T
            WindowsUsbDeviceFactory.Register(new DebugLogger(), new DebugTracer());

            //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
            WindowsHidDeviceFactory.Register(new DebugLogger(), new DebugTracer());

            return base.ConnectAsync();
        }
    }
}
