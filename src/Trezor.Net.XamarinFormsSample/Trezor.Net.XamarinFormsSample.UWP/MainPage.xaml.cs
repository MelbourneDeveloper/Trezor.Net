using Hid.Net.UWP;
using Usb.Net.UWP;
using app = Trezor.Net.XamarinFormsSample.App;

namespace Trezor.Net.XamarinFormsSample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            UWPUsbDeviceFactory.Register();
            UWPHidDeviceFactory.Register();

            LoadApplication(new app());
        }
    }
}
