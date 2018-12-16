using Device.Net;
using LibUsbDotNet.LibUsb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public class WindowsModelTAndOneTests : WindowsTestBase
    {
        #region Fields
        private UsbContext _UsbContext;
        private LibUsbDevice _LibUsbDevice;
        #endregion

        #region Implementation
        protected override async Task<IDevice> Connect()
        {
            _UsbContext = new UsbContext();

            var trezorUsbDevice = _UsbContext.List().FirstOrDefault
                (
                d =>
                //Trezor One - 1.6.x
                (d.ProductId == 0x1 && d.VendorId == 0x534C) ||
                //Trezor One - 1.7.x
                (d.ProductId == 0x53C1 && d.VendorId == 0x1209) ||
                //Trezor Model T ?
                (d.ProductId == 0x53C0 && d.VendorId == 0x1209)
              );

            _LibUsbDevice = new LibUsbDevice(trezorUsbDevice, 60000);
            await _LibUsbDevice.InitializeAsync();

            Console.WriteLine("Connected");

            return _LibUsbDevice;
        }
        #endregion

        #region Setup / Tear Down
        [TestCleanup]
        public void Teardown()
        {
            TrezorManager?.Dispose();
            TrezorManager = null;
            _UsbContext?.Dispose();
        }
        #endregion
    }
}
