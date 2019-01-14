
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Device.Net;
using System.Linq;
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
        private readonly object _ReceiverLock = new object();
        #endregion

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            _TrezorUsbDevice = (AndroidUsbDevice)devices.FirstOrDefault();


            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App(_TrezorUsbDevice));
        }
    }
}