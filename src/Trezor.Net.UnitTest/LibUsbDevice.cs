using Hid.Net;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using System;
using System.Threading.Tasks;

namespace Trezor.Net
{
    public class LibUsbDevice : IHidDevice
    {
        #region Fields
        private UsbEndpointReader _UsbEndpointReader;
        private UsbEndpointWriter _UsbEndpointWriter;
        private int ReadPacketSize;
        #endregion

        #region Public Properties
        public IUsbDevice UsbDevice { get; }
        public int VendorId => UsbDevice.VendorId;
        public int ProductId => UsbDevice.ProductId;
        public int Timeout { get; }
        #endregion

        #region Events
        public event EventHandler Connected;
        public event EventHandler Disconnected;
        #endregion

        #region Constructor
        public LibUsbDevice(IUsbDevice usbDevice, int timeout)
        {
            UsbDevice = usbDevice;
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
            await Task.Run(() =>
            {
                //TODO: Error handling etc.
                UsbDevice.Open();
                UsbDevice.ClaimInterface(UsbDevice.Configs[0].Interfaces[0].Number);
                _UsbEndpointWriter = UsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01);
                _UsbEndpointReader = UsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);
                ReadPacketSize = _UsbEndpointReader.EndpointInfo.MaxPacketSize;
            });
        }

        public async Task<byte[]> ReadAsync()
        {
            return await Task.Run(() =>
            {
                var buffer = new byte[ReadPacketSize];

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
