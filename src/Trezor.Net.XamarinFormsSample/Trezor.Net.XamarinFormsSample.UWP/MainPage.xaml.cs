using Device.Net;
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

            UWPUsbDeviceFactory.Register(new DebugLogger(), new DebugTracer());
            UWPHidDeviceFactory.Register(new DebugLogger(), new DebugTracer());

            LoadApplication(new app());
        }
    }
}
