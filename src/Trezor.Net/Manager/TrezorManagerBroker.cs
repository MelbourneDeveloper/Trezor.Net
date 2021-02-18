using Device.Net;
using System.Collections.Generic;
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
        //Define the types of devices to search for. This particular device can be connected to via USB, or Hid
        protected override List<FilterDeviceDefinition> DeviceDefinitions { get; } = new List<FilterDeviceDefinition>
        {
            new FilterDeviceDefinition{ DeviceType= DeviceType.Hid, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x", UsagePage=65280 },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x (Android Only)" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C1, Label="Trezor One Firmware 1.7.x" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C0, Label="Model T" }
        };

        protected override TrezorManager CreateTrezorManager(IDevice device) => new TrezorManager(EnterPinArgs, EnterPassphraseArgs, device);
        #endregion
    }
}
