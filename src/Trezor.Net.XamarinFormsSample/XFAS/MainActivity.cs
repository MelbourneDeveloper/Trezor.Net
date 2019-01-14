
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Device.Net;
using System.Collections.Generic;
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
        private readonly List<FilterDeviceDefinition> _DeviceDefinitions = new List<FilterDeviceDefinition>
        {
            new FilterDeviceDefinition{ DeviceType= DeviceType.Hid, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x", UsagePage=65280 },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x534C, ProductId=0x0001, Label="Trezor One Firmware 1.6.x (Android Only)" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C1, Label="Trezor One Firmware 1.7.x" },
            new FilterDeviceDefinition{ DeviceType= DeviceType.Usb, VendorId= 0x1209, ProductId=0x53C0, Label="Model T" }
        };

        private AndroidUsbDevice _TrezorUsbDevice;
        private readonly object _ReceiverLock = new object();
        #endregion

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            var devices = await DeviceManager.Current.GetDevices(_DeviceDefinitions);
            _TrezorUsbDevice = (AndroidUsbDevice)devices.FirstOrDefault();


            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App(_TrezorUsbDevice));
        }
    }
}