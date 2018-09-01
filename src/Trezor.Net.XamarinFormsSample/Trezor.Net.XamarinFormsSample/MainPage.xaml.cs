using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        internal async Task DisplayAddressAsync()
        {
            Device.BeginInvokeOnMainThread(async () => 
            {
                var app = Application.Current as App;
                await app.TrezorManager.InitializeAsync();
                TheLabel.Text = await app.TrezorManager.GetAddressAsync("BTC", 0, false, 0, false, AddressType.Bitcoin);
            });
        }
    }
}
