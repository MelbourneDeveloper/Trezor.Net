using Hid.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {

        private MainPage _MainPage;

        public IHidDevice TrezorHidDevice { get; set; }       

        public TrezorManager TezorManager { get; }

        public App(IHidDevice trezorHidDevice)
        {
            TezorManager = new TrezorManager(null, trezorHidDevice);
            InitializeComponent();
            TrezorHidDevice.Connected += TrezorHidDevice_Connected;
            _MainPage = new MainPage();
            MainPage = _MainPage;
        }

        private async void TrezorHidDevice_Connected(object sender, System.EventArgs e)
        {
            _MainPage.DisplayAddressAsync();
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
