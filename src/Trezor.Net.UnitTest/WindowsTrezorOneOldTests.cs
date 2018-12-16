using Device.Net;
using Hid.Net.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsTrezorOneOldTests : WindowsTestBase
    {
        protected override async Task<IDevice> Connect()
        {
            WindowsHidDeviceInformation trezorDeviceInformation = null;

            WindowsHidDevice retVal = null;

            retVal = new WindowsHidDevice();

            Console.Write("Waiting for Trezor .");

            while (trezorDeviceInformation == null)
            {
                var devices = WindowsHidDevice.GetConnectedDeviceInformations().Cast<WindowsHidDeviceInformation>();
                var trezors = devices.Where(d => d.VendorId == TrezorManager.TrezorVendorId && TrezorManager.TrezorProductId == d.ProductId).ToList();
                trezorDeviceInformation = trezors.FirstOrDefault(t => t.UsagePage == TrezorManager.AcceptedUsagePages[0]);

                if (trezorDeviceInformation != null)
                {
                    break;
                }

                await Task.Delay(1000);
                Console.Write(".");
            }

            retVal.DeviceInformation = trezorDeviceInformation;

            await retVal.InitializeAsync();

            Console.WriteLine("Connected");

            return retVal;
        }
    }
}
