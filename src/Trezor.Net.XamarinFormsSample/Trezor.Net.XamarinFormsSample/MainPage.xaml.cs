using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected Overrides
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayAddress();
        }
        #endregion

        #region Event Handlers
        private void App_GetAddress(object sender, System.EventArgs e)
        {
            DisplayAddress();
        }
        #endregion

        #region Private Methods

        private void DisplayAddress()
        {

            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                TheLabel.Text = $"First Bitcoin Address: {await App.GetAddressAsync()}";
                TheActivityIndicator.IsRunning = false;
            });

        }
        #endregion
    }
}
