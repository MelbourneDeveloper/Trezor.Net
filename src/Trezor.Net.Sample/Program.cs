using Device.Net;
using Hardwarewallets.Net.AddressManagement;
using Hid.Net.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trezor.Net;
using Usb.Net.Windows;

namespace TrezorTestApp
{
    internal class Program
    {
        #region Fields
        private static readonly string[] _Addresses = new string[50];
        #endregion

        #region Main
        private static void Main(string[] args)
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
        #endregion

        #region Private  Methods
        private static async Task<IDevice> Connect()
        {
            //Register the factory for creating Usb devices. This only needs to be done once.
            WindowsUsbDeviceFactory.Register();
            WindowsHidDeviceFactory.Register();

            //Get the first available device and connect to it
            var devices = await DeviceManager.Current.GetDevices(TrezorManager.DeviceDefinitions);
            var trezorDevice = devices.FirstOrDefault();

            if (trezorDevice == null)
            {
                throw new Exception("No trezor connected");
            }

            await trezorDevice.InitializeAsync();

            return trezorDevice;
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private static async Task Go()
        {
            try
            {
                using (var trezorHid = await Connect())
                {
                    using (var trezorManager = new TrezorManager(GetPin, trezorHid, new DefaultCoinUtility()))
                    {
                        await trezorManager.InitializeAsync();

                        var tasks = new List<Task>();

                        for (uint i = 0; i < 50; i++)
                        {
                            tasks.Add(DoGetAddress(trezorManager, i));
                        }

                        await Task.WhenAll(tasks);

                        for (uint i = 0; i < 50; i++)
                        {
                            var address = await GetAddress(trezorManager, i);

                            Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                            if (address != _Addresses[i])
                            {
                                throw new Exception("The ordering got messed up");
                            }
                        }

                        var addressPath = new BIP44AddressPath(false, 60, 0, false, 0);

                        var ethAddress = await trezorManager.GetAddressAsync(addressPath, false, false);
                        Console.WriteLine($"First ETH address: {ethAddress}");

                        Console.WriteLine("All good");

                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }

        private static async Task DoGetAddress(TrezorManager trezorManager, uint i)
        {
            var address = await GetAddress(trezorManager, i);
            _Addresses[i] = address;
        }

        private static async Task<string> GetAddress(TrezorManager trezorManager, uint i)
        {
            return await trezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, i), false, false);
        }

        private static async Task<string> GetPin()
        {
            Console.WriteLine("Enter PIN based on Trezor values: ");
            return Console.ReadLine().Trim();
        }
        #endregion
    }
}
