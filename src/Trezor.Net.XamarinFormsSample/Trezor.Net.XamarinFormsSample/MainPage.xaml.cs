using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        private static string _Address;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!string.IsNullOrEmpty(_Address))
            {
                DisplayAddress();
            }
        }

        internal void BeginGetAddress()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var app = Application.Current as App;
                await app.TrezorManager.InitializeAsync();
                _Address = await app.TrezorManager.GetAddressAsync("BTC", 0, false, 0, false, AddressType.Bitcoin);
                DisplayAddress();
            });
        }

        private void DisplayAddress()
        {
            TheLabel.Text = $"First Bitcoin Address: {_Address}";
            TheActivityIndicator.IsRunning = false;
        }
    }
}
