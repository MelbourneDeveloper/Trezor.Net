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
