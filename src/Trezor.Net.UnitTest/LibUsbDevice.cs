using Hid.Net;
using LibUsbDotNet.LibUsb;
using System;
using System.Threading.Tasks;

namespace Trezor.Net.UnitTest
{
    public class LibUsbDevice : IHidDevice
    {
        #region Public Properties
        public IUsbDevice UsbDevice { get;}
        public int VendorId => UsbDevice.VendorId;
        public int ProductId => UsbDevice.ProductId;
        public int ReadBufferSize { get; }
        public int WriteBufferSize { get; }
        public int Timeout { get; }
        #endregion

        UsbEndpointReader UsbEndpointReader;

        #region Events
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        #endregion

        #region Constructor
        public LibUsbDevice(IUsbDevice usbDevice, int readBufferSize, int writeBufferSize, int timeout)
        {
            UsbDevice = usbDevice;
            ReadBufferSize = readBufferSize;
            WriteBufferSize = writeBufferSize;
            Timeout = timeout;
        }
        #endregion

        public void Dispose()
        {
            UsbDevice.Dispose();
        }

        public async Task<bool> GetIsConnectedAsync()
        {
            return true;
        }

        public async Task InitializeAsync()
        {
        }

        public async Task<byte[]> ReadAsync()
        {
            return Task.Run<byte[]>((a) ={
                var buffer = new byte[ReadBufferSize];

                UsbEndpointReader.Read(buffer, )
            });
        }

        public Task WriteAsync(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
