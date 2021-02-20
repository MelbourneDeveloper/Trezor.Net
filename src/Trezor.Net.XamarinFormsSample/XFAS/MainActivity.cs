
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Android.Widget;
using Device.Net;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Usb.Net.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Trezor.Net.XamarinFormsSample.Droid
{
    [IntentFilter(new[] { UsbManager.ActionUsbDeviceAttached })]
    [Activity(Label = "Trezor.Net.XamarinFormsSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        #region Fields
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            Go();
        }

        private void Go()
        {
            try
            {
                var usbManager = GetSystemService(UsbService) as UsbManager;
                if (usbManager == null) throw new Exception("UsbManager is null");

                TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                //Register the factory for creating Usb devices. This only needs to be done once.
                var deviceFactory = TrezorManager.DeviceDefinitions.CreateAndroidUsbDeviceFactory(usbManager, base.ApplicationContext, _loggerFactory);

                LoadApplication(new App(deviceFactory));
            }
            catch (Exception ex)
            {
                Toast.MakeText(ApplicationContext, ex.ToString(), ToastLength.Long).Show();
            }
        }
    }
}