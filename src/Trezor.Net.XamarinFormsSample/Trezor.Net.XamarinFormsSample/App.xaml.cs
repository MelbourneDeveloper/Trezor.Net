using Hid.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {

        private MainPage _MainPage;

        public static NavigationPage MainNavigationPage => Current.MainPage as NavigationPage;

        public TrezorManager TrezorManager { get; }

        public App(IHidDevice trezorHidDevice)
        {
            TrezorManager = new TrezorManager(TrezorPinPad.GetPin, trezorHidDevice);
            InitializeComponent();
            trezorHidDevice.Connected += TrezorHidDevice_Connected;
            _MainPage = new MainPage();
            var mainNavigationPage = new NavigationPage(_MainPage);
            MainPage = mainNavigationPage; 
        }

        private async void TrezorHidDevice_Connected(object sender, System.EventArgs e)
        {
            await _MainPage.DisplayAddressAsync();
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
