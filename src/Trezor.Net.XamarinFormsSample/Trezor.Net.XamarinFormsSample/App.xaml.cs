using Device.Net;
using Hardwarewallets.Net.AddressManagement;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {
        #region Fields
        private static TrezorManager _TrezorManager;
        #endregion

        #region Public Static Propertoes
        public static NavigationPage MainNavigationPage { get; private set; }
        #endregion

        #region Constructor
        public App(IDevice trezorHidDevice)
        {
            _TrezorManager = new TrezorManager(TrezorPinPad.GetPin, trezorHidDevice, new DefaultCoinUtility());
            InitializeComponent();
            MainNavigationPage = new NavigationPage(new MainPage());
            MainPage = MainNavigationPage;
        }
        #endregion

        public static async Task<string> GetAddressAsync()
        {
            await _TrezorManager.Device.InitializeAsync();
            await _TrezorManager.InitializeAsync();
            return  await _TrezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, 0), false, true);
        }

        #region Protected Overrides
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
        #endregion
    }
}
