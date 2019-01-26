using Device.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Net.Manager
{
    public class TrezorManagerBroker : IDisposable
    {
        #region Fields
        private ReadOnlyCollection<TrezorManager> _TrezorManagers = new ReadOnlyCollection<TrezorManager>(new List<TrezorManager>());
        private DeviceListener _DeviceListener;
        private SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private TaskCompletionSource<TrezorManager> _FirstTrezorTaskCompletionSource = new TaskCompletionSource<TrezorManager>();

        //Define the types of devices to search for. This particular device can be connected to via USB, or Hid
        private static readonly List<FilterDeviceDefinition> _DeviceDefinitions = new List<FilterDeviceDefinition>
        {
            new FilterDeviceDefinition{ DeviceType= DeviceType.Hid, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x", UsagePage=65280 },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x (Android Only)" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C1, Label="Trezor One Firmware 1.7.x" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C0, Label="Model T" }
        };
        #endregion

        #region Events
        /// <summary>
        /// Occurs after the TrezorManagerBroker notices that a device hasbeen connected, and initialized
        /// </summary>
        public event EventHandler<TrezorManagerConnectionEventArgs> TrezorInitialized;

        /// <summary>
        /// Occurs after the TrezorManagerBroker notices that the device has been disconnected, but before the TrezorManager is disposed
        /// </summary>
        public event EventHandler<TrezorManagerConnectionEventArgs> TrezorDisconnected;
        #endregion

        #region Public Properties
        public IEnumerable<TrezorManager> TrezorManagers => _TrezorManagers;
        public EnterPinArgs EnterPinArgs { get; }
        public ICoinUtility CoinUtility { get; }
        public int? PollInterval { get; }
        #endregion

        #region Constructor
        public TrezorManagerBroker(EnterPinArgs enterPinArgs, int? pollInterval, ICoinUtility coinUtility)
        {
            EnterPinArgs = enterPinArgs;
            CoinUtility = coinUtility;
            PollInterval = pollInterval;
        }
        #endregion

        #region Event Handlers
        private async void DevicePoller_DeviceInitialized(object sender, DeviceEventArgs e)
        {
            try
            {
                await _Lock.WaitAsync();

                var trezorManager = _TrezorManagers.FirstOrDefault(t => ReferenceEquals(t.Device, e.Device));
                if (trezorManager == null)
                {
                    trezorManager = new TrezorManager(EnterPinArgs, e.Device, CoinUtility);

                    var tempList = new List<TrezorManager>(_TrezorManagers)
                    {
                        trezorManager
                    };

                    _TrezorManagers = new ReadOnlyCollection<TrezorManager>(tempList);

                    await trezorManager.InitializeAsync();

                    if (_FirstTrezorTaskCompletionSource.Task.Status == TaskStatus.WaitingForActivation) _FirstTrezorTaskCompletionSource.SetResult(trezorManager);

                    TrezorInitialized?.Invoke(this, new TrezorManagerConnectionEventArgs(trezorManager));
                }
            }
            finally
            {
                _Lock.Release();
            }
        }

        private async void DevicePoller_DeviceDisconnected(object sender, DeviceEventArgs e)
        {
            try
            {
                await _Lock.WaitAsync();

                var trezorManager = _TrezorManagers.FirstOrDefault(t => ReferenceEquals(t.Device, e.Device));
                if (trezorManager != null)
                {
                    TrezorDisconnected?.Invoke(this, new TrezorManagerConnectionEventArgs(trezorManager));

                    trezorManager.Dispose();

                    var tempList = new List<TrezorManager>(_TrezorManagers);

                    tempList.Remove(trezorManager);

                    _TrezorManagers = new ReadOnlyCollection<TrezorManager>(tempList);
                }
            }
            finally
            {
                _Lock.Release();
            }
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Placeholder. This currently does nothing but you should call this to initialize listening
        /// </summary>
        public void Start()
        {
            if (_DeviceListener == null)
            {
                _DeviceListener = new DeviceListener(_DeviceDefinitions, PollInterval);
                _DeviceListener.DeviceDisconnected += DevicePoller_DeviceDisconnected;
                _DeviceListener.DeviceInitialized += DevicePoller_DeviceInitialized;
            }

            //TODO: Call Start on the DeviceListener when it is implemented...
        }

        public void Stop()
        {
            _DeviceListener?.Stop();
        }

        /// <summary>
        /// Starts the device listener and waits for the first connected Trezor to be initialized
        /// </summary>
        /// <returns></returns>
        public async Task<TrezorManager> WaitForFirstTrezorAsync()
        {
            //TODO: this should call GetDevicesAsync on the DeviceListener to get all connected devices. This basically a deficiency in DeviceListener
            //See https://github.com/MelbourneDeveloper/Device.Net/issues/28

            if (_DeviceListener == null) Start();
            return await _FirstTrezorTaskCompletionSource.Task;
        }

        public void Dispose()
        {
            _DeviceListener.Stop();

            //TODO: 
            //_DeviceListener.Dispose();

            foreach (var trezorManager in _TrezorManagers)
            {
                trezorManager.Dispose();
            }
        }
        #endregion
    }
}
