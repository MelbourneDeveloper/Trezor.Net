using System;

namespace Trezor.Net.Manager
{
    public class TrezorManagerConnectionEventArgs<TMessageType> : EventArgs
    {
        public TrezorManagerBase<TMessageType> TrezorManager { get; }

        public TrezorManagerConnectionEventArgs(TrezorManagerBase<TMessageType> trezorManager) => TrezorManager = trezorManager;
    }
}
