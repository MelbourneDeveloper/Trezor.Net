using Device.Net;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Trezor.Net.XamarinFormsSample
{
    public partial class App : Application
    {
        #region Public Static Propertoes
        public static NavigationPage MainNavigationPage { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Look mum! No dependency injected variables!
        /// </summary>
        public App(IDeviceFactory deviceFactory)
        {
            InitializeComponent();
            MainNavigationPage = new NavigationPage(new MainPage(deviceFactory));
            MainPage = MainNavigationPage;
        }
        #endregion

        #region Protected Overrides
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
