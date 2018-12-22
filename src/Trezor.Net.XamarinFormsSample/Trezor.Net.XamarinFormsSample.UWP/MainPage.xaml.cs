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
            UWPUsbDeviceFactory.Register();
            UWPHidDeviceFactory.Register();

            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            var trezorDevice = devices.FirstOrDefault();

            if (trezorDevice == null)
            {
                throw new System.Exception("No Trezor was connected");
            }

            await trezorDevice.InitializeAsync();
            LoadApplication(new app(trezorDevice));
        }
    }
}
