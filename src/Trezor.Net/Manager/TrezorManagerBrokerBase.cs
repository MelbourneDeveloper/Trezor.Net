using Device.Net;
using System.Collections.Generic;

namespace Trezor.Net.Manager
{
    public abstract class TrezorManagerBrokerBase
    {
        #region Protected Abstract Properties
        protected abstract List<FilterDeviceDefinition> DeviceDefinitions { get; }
        #endregion
    }
}
