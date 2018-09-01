using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            App.GetAddress += App_GetAddress;
        }

        private void App_GetAddress(object sender, System.EventArgs e)
        {
            DisplayAddress();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!string.IsNullOrEmpty(App.Address))
            {
                DisplayAddress();
            }
        }

        private void DisplayAddress()
        {
            TheLabel.Text = $"First Bitcoin Address: {App.Address}";
            TheActivityIndicator.IsRunning = false;
        }
    }
}
