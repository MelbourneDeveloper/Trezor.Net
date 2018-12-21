using Device.Net;
using Hid.Net.UWP;
using System.Linq;
using System.Threading.Tasks;
using Usb.Net.UWP;
using app = Trezor.Net.XamarinFormsSample.App;

namespace Trezor.Net.XamarinFormsSample.UWP
{
    public sealed partial class MainPage
    {

        public MainPage()
        {
            InitializeComponent();

            Go();
        }

        private async Task Go()
        {
            DeviceDefinition trezorDeviceDefinition;
            IDevice trezorHidDevice = null;

            foreach (var deviceDefinition in TrezorManager.DeviceDefinitions)
            {
                var definitions = await DeviceManager.Current.GetConnectedDeviceDefinitions(deviceDefinition.VendorId, deviceDefinition.ProductId, deviceDefinition.DeviceType);
                trezorDeviceDefinition = definitions.FirstOrDefault();
                if (trezorDeviceDefinition != null)
                {
                    switch (trezorDeviceDefinition.DeviceType)
                    {
                        case DeviceType.Hid:
                            trezorHidDevice = new UWPHidDevice(trezorDeviceDefinition.DeviceId);
                            break;
                        case DeviceType.Usb:
                            trezorHidDevice = new UWPUsbDevice(trezorDeviceDefinition.DeviceId);
                            break;
                    }
                    await trezorHidDevice.InitializeAsync();
                    LoadApplication(new app(trezorHidDevice));
                    break;
                }
            }

            if (trezorHidDevice == null)
            {
                throw new System.Exception("No Trezor was connected");
            }
        }
    }
}
