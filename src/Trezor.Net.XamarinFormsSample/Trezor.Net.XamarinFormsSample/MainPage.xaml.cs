using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            App.GetAddress += App_GetAddress;
        }
        #endregion

        #region Protected Overrides
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!string.IsNullOrEmpty(App.Address))
            {
                DisplayAddress();
            }
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
            TheLabel.Text = $"First Bitcoin Address: {App.Address}";
            TheActivityIndicator.IsRunning = false;
        }
        #endregion
    }
}
