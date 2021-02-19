using Device.Net;
using Trezor.Net.Contracts;

namespace Trezor.Net.Manager
{
    public class TrezorManagerBroker : TrezorManagerBrokerBase<TrezorManager, MessageType>
    {
        #region Constructor
        public TrezorManagerBroker(EnterPinArgs enterPinArgs, EnterPinArgs enterPassphraseArgs, int? pollInterval, ICoinUtility coinUtility) : base(enterPinArgs, enterPassphraseArgs, pollInterval, coinUtility)
        {
        }
        #endregion

        #region Protected Overrides
        protected override TrezorManager CreateTrezorManager(IDevice device) => new TrezorManager(EnterPinArgs, EnterPassphraseArgs, device);
        #endregion
    }
}
