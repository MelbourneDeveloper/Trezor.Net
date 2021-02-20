using Hardwarewallets.Net.AddressManagement;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Trezor.Net.Manager;
using Xamarin.Forms;
using Device.Net;

#pragma warning disable CA1501

namespace Trezor.Net.XamarinFormsSample
{
    public partial class MainPage : ContentPage
    {
        #region Fields
        private TrezorManagerBroker TrezorManagerBroker;
        private bool _IsDisplayed;
        private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));
        private readonly IDeviceFactory deviceFactory;
        #endregion

        #region Constructor
        public MainPage(IDeviceFactory deviceFactory)
        {
            InitializeComponent();
            this.deviceFactory = deviceFactory;
        }
        #endregion

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_IsDisplayed) return;
            _IsDisplayed = true;

            TrezorManagerBroker = new TrezorManagerBroker(TrezorPinPad.GetPin, () => { return Task.FromResult("a"); }, 2000, new DefaultCoinUtility(), deviceFactory, _loggerFactory);

            var trezorManager = await TrezorManagerBroker.WaitForFirstTrezorAsync().ConfigureAwait(false);

            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                var address = await trezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, 0), false, true).ConfigureAwait(false);
                TheLabel.Text = $"First Bitcoin Address: {address}";
                TheActivityIndicator.IsRunning = false;
            });
        }
    }
}
