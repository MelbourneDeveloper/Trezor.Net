
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware.Usb;
using Android.OS;
using Hid.Net.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Trezor.Net.XamarinFormsSample.Droid
{
    [IntentFilter(new[] { UsbManager.ActionUsbDeviceAttached })]
    [Activity(Label = "Trezor.Net.XamarinFormsSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        #region Fields
        private AndroidHidDevice _TrezorHidDevice;
        private UsbDeviceAttachedReceiver _TrezorUsbDeviceAttachedReceiver;
        private UsbDeviceDetachedReceiver _TrezorUsbDeviceDetachedReceiver;
        private readonly object _ReceiverLock = new object();
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Firmware 1.6.x
            _TrezorHidDevice = new AndroidHidDevice(GetSystemService(UsbService) as UsbManager, ApplicationContext, 3000, 64, TrezorManager.TrezorVendorId, TrezorManager.TrezorProductId);

            //Firmware 1.7.x / Trezor Model T
            //_TrezorHidDevice = new AndroidHidDevice(GetSystemService(UsbService) as UsbManager, ApplicationContext, 3000, 64, 0x1209, 0x53C1);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);
            RegisterReceiver();
            LoadApplication(new App(_TrezorHidDevice));
        }

        protected override void OnResume()
        {
            base.OnResume();
            RegisterReceiver();
        }

        private void RegisterReceiver()
        {
            try
            {
                lock (_ReceiverLock)
                {
                    if (_TrezorUsbDeviceAttachedReceiver != null)
                    {
                        UnregisterReceiver(_TrezorUsbDeviceAttachedReceiver);
                        _TrezorUsbDeviceAttachedReceiver.Dispose();
                    }

                    _TrezorUsbDeviceAttachedReceiver = new UsbDeviceAttachedReceiver(_TrezorHidDevice);
                    RegisterReceiver(_TrezorUsbDeviceAttachedReceiver, new IntentFilter(UsbManager.ActionUsbDeviceAttached));


                    if (_TrezorUsbDeviceDetachedReceiver != null)
                    {
                        UnregisterReceiver(_TrezorUsbDeviceDetachedReceiver);
                        _TrezorUsbDeviceDetachedReceiver.Dispose();
                    }


                    _TrezorUsbDeviceDetachedReceiver = new UsbDeviceDetachedReceiver(_TrezorHidDevice);
                    RegisterReceiver(_TrezorUsbDeviceDetachedReceiver, new IntentFilter(UsbManager.ActionUsbDeviceDetached));
                }
            }
            catch
            {

            }
        }
    }
}