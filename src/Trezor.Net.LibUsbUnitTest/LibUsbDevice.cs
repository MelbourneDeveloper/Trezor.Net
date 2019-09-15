using Device.Net;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Net
{
    public class LibUsbDevice : IDevice
    {
        #region Fields
        private UsbEndpointReader _UsbEndpointReader;
        private UsbEndpointWriter _UsbEndpointWriter;
        private int ReadPacketSize;
        private SemaphoreSlim _WriteAndReadLock = new SemaphoreSlim(1, 1);
        #endregion

        #region Public Properties
        public IUsbDevice UsbDevice { get; }
        public int VendorId => UsbDevice.VendorId;
        public int ProductId => UsbDevice.ProductId;
        public int Timeout { get; }
        public bool IsInitialized => true;
        public ConnectedDeviceDefinitionBase ConnectedDeviceDefinition => throw new NotImplementedException();
        public string DeviceId => throw new NotImplementedException();
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

        public void Close()
        {
            UsbDevice.Close();
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

        public async Task<ReadResult> ReadAsync()
        {
            await _WriteAndReadLock.WaitAsync();

            try
            {
                return await Task.Run(() =>
                {
                    var buffer = new byte[ReadPacketSize];

                    _UsbEndpointReader.Read(buffer, Timeout, out var bytesRead);

                    return buffer;
                });
            }
            finally
            {
                _WriteAndReadLock.Release();
            }
        }

        public async Task WriteAsync(byte[] data)
        {
            await _WriteAndReadLock.WaitAsync();

            try
            {
                await Task.Run(() =>
                {
                    _UsbEndpointWriter.Write(data, Timeout, out var bytesWritten);
                });
            }
            finally
            {
                _WriteAndReadLock.Release();
            }
        }

        public async Task<ReadResult> WriteAndReadAsync(byte[] writeBuffer)
        {
            await WriteAsync(writeBuffer);
            return await ReadAsync();
        }

        public async Task Flush()
        {
        }
        #endregion
    }
}
