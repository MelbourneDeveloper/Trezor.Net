﻿using Device.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Trezor.Net.Manager
{
    public abstract class TrezorManagerBrokerBase<T, TMessageType> where T : TrezorManagerBase<TMessageType>
    {
        #region Protected Abstract Properties
        protected abstract List<FilterDeviceDefinition> DeviceDefinitions { get; }
        #endregion

        #region Fields
        private ReadOnlyCollection<T> _TrezorManagers = new ReadOnlyCollection<T>(new List<T>());
        private DeviceListener _DeviceListener;
        private SemaphoreSlim _Lock = new SemaphoreSlim(1, 1);
        private TaskCompletionSource<T> _FirstTrezorTaskCompletionSource = new TaskCompletionSource<T>();
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
        public IEnumerable<T> TrezorManagers => _TrezorManagers;
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

        #region Event Handlers
        private async void DevicePoller_DeviceInitialized(object sender, DeviceEventArgs e)
        {
            try
            {
                await _Lock.WaitAsync();

                var T = _TrezorManagers.FirstOrDefault(t => ReferenceEquals(t.Device, e.Device));
                if (trezorManager == null)
                {
                    trezorManager = new T(EnterPinArgs, e.Device, CoinUtility);

                    var tempList = new List<T>(_TrezorManagers)
                    {
                        trezorManager
                    };

                    _TrezorManagers = new ReadOnlyCollection<T>(tempList);

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
                _DeviceListener = new DeviceListener(DeviceDefinitions, PollInterval);
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

            foreach (var trezorManager in _TrezorManagers)
            {
                trezorManager.Dispose();
            }
        }
        #endregion
    }
}



