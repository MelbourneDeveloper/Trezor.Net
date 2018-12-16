using Device.Net;
using Hardwarewallets.Net.AddressManagement;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {
        #region Fields
        private TrezorManager _TrezorManager;
        #endregion

        #region Public Static Propertoes
        public static string Address;
        public static NavigationPage MainNavigationPage { get; private set; }
        #endregion

        #region Public Static Events
        public static event EventHandler GetAddress;
        #endregion

        #region Constructor
        public App(IDevice trezorHidDevice)
        {
            _TrezorManager = new TrezorManager(TrezorPinPad.GetPin, trezorHidDevice, new DefaultCoinUtility());
            InitializeComponent();
            trezorHidDevice.Connected += TrezorHidDevice_Connected;
            MainNavigationPage = new NavigationPage(new MainPage());
            MainPage = MainNavigationPage;
        }
        #endregion

        #region Event Handlers
        private void TrezorHidDevice_Connected(object sender, System.EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                await _TrezorManager.InitializeAsync();
                Address = await _TrezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, 0), false, true);
                GetAddress?.Invoke(this, new EventArgs());
            });
        }
        #endregion

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
