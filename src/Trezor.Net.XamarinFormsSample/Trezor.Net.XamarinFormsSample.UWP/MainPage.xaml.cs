using Device.Net;
using Hid.Net.UWP;
using System.Threading.Tasks;
using app = Trezor.Net.XamarinFormsSample.App;

namespace Trezor.Net.XamarinFormsSample.UWP
{
    public sealed partial class MainPage
    {
        private UWPHidDevicePoller poller;

        public MainPage()
        {
            InitializeComponent();

            var taskCompletionSource = new TaskCompletionSource<IDevice>();
            var trezorHidDevice = new UWPHidDevice();
            trezorHidDevice.Connected += TrezorHidDevice_Connected;
            poller = new UWPHidDevicePoller(TrezorManager.TrezorProductId, TrezorManager.TrezorVendorId, trezorHidDevice);
            LoadApplication(new app(trezorHidDevice));
        }

        private void TrezorHidDevice_Connected(object sender, System.EventArgs e)
        {
            poller.Stop();
        }
    }
}
