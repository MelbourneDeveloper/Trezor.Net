using Device.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Net.Manager
{
    public abstract class TrezorManagerBrokerBase<T, TMessageType> where T : TrezorManagerBase<TMessageType>, IDisposable
    {
        #region Protected Abstract Properties
        protected abstract List<FilterDeviceDefinition> DeviceDefinitions { get; }

        #endregion
        #region Fields
        private DeviceListener _DeviceListener;
        private SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private TaskCompletionSource<T> _FirstTrezorTaskCompletionSource = new TaskCompletionSource<T>();
        #endregion

        #region Events
        /// <summary>
        /// Occurs after the TrezorManagerBroker notices that a device hasbeen connected, and initialized
        /// </summary>
        public event EventHandler<TrezorManagerConnectionEventArgs<TMessageType>> TrezorInitialized;

        /// <summary>
        /// Occurs after the TrezorManagerBroker notices that the device has been disconnected, but before the TrezorManager is disposed
        /// </summary>
        public event EventHandler<TrezorManagerConnectionEventArgs<TMessageType>> TrezorDisconnected;
        #endregion

        #region Public Properties
        public ReadOnlyCollection<T> TrezorManagers { get; private set; } = new ReadOnlyCollection<T>(new List<T>());
        public EnterPinArgs EnterPinArgs { get; }
        public ICoinUtility CoinUtility { get; }
        public int? PollInterval { get; }
        #endregion

        #region Constructor
        protected TrezorManagerBrokerBase(EnterPinArgs enterPinArgs, int? pollInterval, ICoinUtility coinUtility)
        {
            EnterPinArgs = enterPinArgs;
            CoinUtility = coinUtility;
            PollInterval = pollInterval;
        }
        #endregion

        #region Protected Abstract Methods
        protected abstract T CreateTrezorManager(IDevice device);
        #endregion

        #region Event Handlers
        private async void DevicePoller_DeviceInitialized(object sender, DeviceEventArgs e)
        {
            try
            {
                await _Lock.WaitAsync();

                var trezorManager = TrezorManagers.FirstOrDefault(t => ReferenceEquals(t.Device, e.Device));
                if (trezorManager == null)
                {
                    trezorManager = CreateTrezorManager(e.Device);

                    var tempList = new List<T>(TrezorManagers)
                    {
                        trezorManager
                    };

                    TrezorManagers = new ReadOnlyCollection<T>(tempList);

                    await trezorManager.InitializeAsync();

                    if (_FirstTrezorTaskCompletionSource.Task.Status == TaskStatus.WaitingForActivation) _FirstTrezorTaskCompletionSource.SetResult(trezorManager);

                    TrezorInitialized?.Invoke(this, new TrezorManagerConnectionEventArgs<TMessageType>(trezorManager));
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

                var trezorManager = TrezorManagers.FirstOrDefault(t => ReferenceEquals(t.Device, e.Device));
                if (trezorManager != null)
                {
                    TrezorDisconnected?.Invoke(this, new TrezorManagerConnectionEventArgs<TMessageType>(trezorManager));

                    trezorManager.Dispose();

                    var tempList = new List<T>(TrezorManagers);

                    tempList.Remove(trezorManager);

                    TrezorManagers = new ReadOnlyCollection<T>(tempList);
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
                _DeviceListener = new DeviceListener(DeviceDefinitions, PollInterval);
                _DeviceListener.DeviceDisconnected += DevicePoller_DeviceDisconnected;
                _DeviceListener.DeviceInitialized += DevicePoller_DeviceInitialized;
                _DeviceListener.Start();
            }

            //TODO: Call Start on the DeviceListener when it is implemented...
        }

        public void Stop()
        {
            _DeviceListener?.Stop();
        }

        /// <summary>
        /// Check to see if there are any devices connected
        /// </summary>
        public async Task CheckForDevicesAsync()
        {
            try
            {
                await _DeviceListener.CheckForDevicesAsync();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Starts the device listener and waits for the first connected Trezor to be initialized
        /// </summary>
        /// <returns></returns>
        public async Task<T> WaitForFirstTrezorAsync()
        {
            if (_DeviceListener == null) Start();
            await _DeviceListener.CheckForDevicesAsync();
            return await _FirstTrezorTaskCompletionSource.Task;
        }

        public void Dispose()
        {
            _DeviceListener.Stop();

            //TODO: 
            //_DeviceListener.Dispose();

            foreach (var trezorManager in TrezorManagers)
            {
                trezorManager.Dispose();
            }
        }
        #endregion
    }
}



