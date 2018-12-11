using Hid.Net;
using LibUsbDotNet.LibUsb;
using System;
using System.Threading.Tasks;

namespace Trezor.Net
{
    public class LibUsbDevice : IHidDevice
    {
        #region Fields
        private UsbEndpointReader _UsbEndpointReader;
        private readonly UsbEndpointWriter _UsbEndpointWriter;
        #endregion

        #region Public Properties
        public IUsbDevice UsbDevice { get; }
        public int VendorId => UsbDevice.VendorId;
        public int ProductId => UsbDevice.ProductId;
        public int ReadBufferSize { get; }
        public int WriteBufferSize { get; }
        public int Timeout { get; }
        #endregion

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

        #region Implementation
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
            return await Task.Run(() =>
            {
                var buffer = new byte[ReadBufferSize];

                _UsbEndpointReader.Read(buffer, Timeout, out var bytesRead);

                return buffer;
            });
        }

        public async Task WriteAsync(byte[] data)
        {
            await Task.Run(() =>
            {
               _UsbEndpointWriter.Write(data, Timeout, out var bytesWritten);
            });
        }
        #endregion
    }
}
