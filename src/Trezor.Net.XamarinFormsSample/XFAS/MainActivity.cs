
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Device.Net;
using System;
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
        #endregion

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            //TODO: Error handling. If something goes wrong here, or the device is not connected the whole app will crash

            var usbManager = GetSystemService(UsbService) as UsbManager;
            if (usbManager == null) throw new Exception("UsbManager is null");

            //Register the factory for creating Usb devices. This only needs to be done once.
            AndroidUsbDeviceFactory.Register(usbManager, base.ApplicationContext);


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