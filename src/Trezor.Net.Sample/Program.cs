using Hid.Net;
using System;
using System.Linq;
using System.Threading.Tasks;
using Trezor.Manager;
using static Trezor.Manager.TrezorManager;

namespace TrezorTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Go();
                while (true) ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static async Task<IHidDevice> Connect()
        {
            var devices = WindowsHidDevice.GetConnectedDeviceInformations();
            var trezors = devices.Where(d => d.VendorId == TrezorManager.TrezorVendorId && TrezorManager.TrezorProductId == 1);

            DeviceInformation trezorDeviceInformation;

            trezorDeviceInformation = trezors.FirstOrDefault(t => t.Product == USBOneName);

            if (trezorDeviceInformation == null)
            {
                throw new Exception("No Trezor is not connected or USB access was not granted to this application.");
            }

            var retVal = new WindowsHidDevice(trezorDeviceInformation);

            await retVal.InitializeAsync();

            return retVal;
        }

        private async static Task Go()
        {
            using (var trezorHid = await Connect())
            {
                using (var trezorManager = new TrezorManager(GetPin, trezorHid))
                {
                    await trezorManager.InitializeAsync();

                    var address = await trezorManager.GetAddressAsync("CRW", 72, false, 0, false, AddressType.Bitcoin);

                    Console.WriteLine(address);

                    Console.ReadLine();
                }
            }
        }

        public async static Task<string> GetPin()
        {
            Console.WriteLine("Enter PIN based on Trezor values: ");
            return Console.ReadLine().Trim();
        }
    }
}
