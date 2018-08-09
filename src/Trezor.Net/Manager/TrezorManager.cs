using Hid.Net;
using System.Threading.Tasks;

namespace Trezor.Manager
{
    public class TrezorManager : TrezorManagerBase
    {
        #region Public Constants
        public const ushort TrezorVendorId = 21324;
        public const int TrezorProductId = 1;
        public const string USBOneName = "TREZOR Interface";
        //TODO: This might not be cool.
        private const string LogSection = "Trezor Manager";
        #endregion

        #region Constructor
        public TrezorManager(EnterPinArgs enterPinCallback, IHidDevice trezorHidDevice) : base(enterPinCallback, trezorHidDevice)
        {
        }
        #endregion

        #region Protected Overrides
        protected override async Task<object> PinMatrixAckAsync(string pin)
        {
            var retVal = await SendMessageAsync(new PinMatrixAck { Pin = pin });

            if (retVal is Failure failure)
            {
                throw new FailureException("PIN Attempt Failed.", failure);
            }

            return retVal;
        }

        protected override async Task<object> ButtonAckAsync()
        {
            var retVal = await SendMessageAsync(new ButtonAck());

            if (retVal is Failure failure)
            {
                throw new FailureException("PIN Attempt Failed.", failure);
            }

            return retVal;
        }
        #endregion
    }
}
