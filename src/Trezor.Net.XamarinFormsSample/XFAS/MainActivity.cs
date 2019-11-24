
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Android.Widget;
using Device.Net;
using System;
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
        private AndroidUsbDevice _TrezorUsbDevice;
        #endregion

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            Go();
        }

        private async Task Go()
        {
            try
            {
                var usbManager = GetSystemService(UsbService) as UsbManager;
                if (usbManager == null) throw new Exception("UsbManager is null");

                //Register the factory for creating Usb devices. This only needs to be done once.
                AndroidUsbDeviceFactory.Register(usbManager, base.ApplicationContext, new DebugLogger(), new DebugTracer());

                TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                LoadApplication(new App());
            }
            catch (Exception ex)
            {
                Toast.MakeText(ApplicationContext, ex.ToString(), ToastLength.Long).Show();
            }
        }
    }
}