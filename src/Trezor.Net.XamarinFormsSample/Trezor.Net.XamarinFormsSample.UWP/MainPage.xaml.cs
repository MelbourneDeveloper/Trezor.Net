using Device.Net;
using Device.Net.UWP;
using Hid.Net.UWP;
using System.Threading.Tasks;
using app = Trezor.Net.XamarinFormsSample.App;

namespace Trezor.Net.XamarinFormsSample.UWP
{
    public sealed partial class MainPage
    {
        private UWPDevicePoller poller;

        public MainPage()
        {
            InitializeComponent();

            var taskCompletionSource = new TaskCompletionSource<IDevice>();
            var trezorHidDevice = new UWPHidDevice();
            trezorHidDevice.Connected += TrezorHidDevice_Connected;
            poller = new UWPDevicePoller(TrezorManager.TrezorProductId, TrezorManager.TrezorVendorId, DeviceType.Hid, trezorHidDevice);
            LoadApplication(new app(trezorHidDevice));
        }

        private void TrezorHidDevice_Connected(object sender, System.EventArgs e)
        {
            poller.Stop();
        }
    }
}
