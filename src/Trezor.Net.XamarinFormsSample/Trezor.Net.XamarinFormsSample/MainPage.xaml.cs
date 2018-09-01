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
            var app = Application.Current as App;
            TheLabel.Text = await app.TezorManager.GetAddressAsync("BTC", 0, false, 0, false, AddressType.Bitcoin);
        }
    }
}
