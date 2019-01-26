using Hardwarewallets.Net.AddressManagement;
using Trezor.Net.Manager;
using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        #region Fields
        private TrezorManagerBroker TrezorManagerBroker;
        private bool _IsDisplayed;
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_IsDisplayed) return;
            _IsDisplayed = true;

            TrezorManagerBroker = new TrezorManagerBroker(TrezorPinPad.GetPin, 2000, new DefaultCoinUtility());

            var trezorManager = await TrezorManagerBroker.WaitForFirstTrezorAsync();

            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                var address = await trezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, 0), false, true);
                TheLabel.Text = $"First Bitcoin Address: {address}";
                TheActivityIndicator.IsRunning = false;
            });
        }
    }
}
