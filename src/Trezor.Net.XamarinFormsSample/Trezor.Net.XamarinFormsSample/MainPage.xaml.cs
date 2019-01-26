using Hardwarewallets.Net.AddressManagement;
using Trezor.Net.Manager;
using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        #region Fields
        private bool IsDisplayed;
        private TrezorManagerBroker TrezorManagerBroker;
        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            TrezorManagerBroker.Start();
        }
        #endregion

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            TrezorManagerBroker = new TrezorManagerBroker(TrezorPinPad.GetPin, 2000, new DefaultCoinUtility());

            var trezorManager = await TrezorManagerBroker.WaitForFirstTrezorAsync();

            var address = await trezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, 0), false, true);

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                TheLabel.Text = $"First Bitcoin Address: {address}";
                TheActivityIndicator.IsRunning = false;
            });
        }
    }
}
