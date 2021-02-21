using Device.Net;
using Microsoft.Extensions.Logging;
using Trezor.Net.Contracts;

namespace Trezor.Net.Manager
{
    public class TrezorManagerBroker : TrezorManagerBrokerBase<TrezorManager, MessageType>
    {
        #region Constructor
        public TrezorManagerBroker(
            EnterPinArgs enterPinArgs,
            EnterPinArgs enterPassphraseArgs,
            int? pollInterval,
            ICoinUtility coinUtility,
            IDeviceFactory deviceFactory,
            ILoggerFactory loggerFactory = null
            ) : base(
                enterPinArgs,
                enterPassphraseArgs,
                pollInterval,
                deviceFactory,
                coinUtility,
                loggerFactory)
        {
        }
        #endregion

        #region Protected Overrides
        protected override TrezorManager CreateTrezorManager(IDevice device) => new TrezorManager(EnterPinArgs, EnterPassphraseArgs, device, LoggerFactory.CreateLogger<TrezorManager>());
        #endregion
    }
}
