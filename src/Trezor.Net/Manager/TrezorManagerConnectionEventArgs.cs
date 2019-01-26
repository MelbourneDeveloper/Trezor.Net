using System;

namespace Trezor.Net.Manager
{
    public class TrezorManagerConnectionEventArgs : EventArgs
    {
        public TrezorManager TrezorManager { get; }

        public TrezorManagerConnectionEventArgs(TrezorManager trezorManager)
        {
            TrezorManager = trezorManager;
        }
    }
}
