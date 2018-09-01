using Hid.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {
        public IHidDevice TrezorHidDevice { get; set; }

        public App(IHidDevice trezorHidDevice)
        {
            TrezorHidDevice = trezorHidDevice;
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
