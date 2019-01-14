using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        private bool IsDisplayed;

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


        #region Private Methods
        private void DisplayAddress()
        {
            if (IsDisplayed) return;

            IsDisplayed = true;

            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                TheLabel.Text = $"First Bitcoin Address: {await App.GetAddressAsync()}";
                TheActivityIndicator.IsRunning = false;
            });
        }
        #endregion
    }
}
