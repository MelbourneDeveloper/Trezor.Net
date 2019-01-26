using Hardwarewallets.Net.AddressManagement;
using Hid.Net.Windows;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trezor.Net;
using Trezor.Net.Manager;
using Usb.Net.Windows;

namespace TrezorTestApp
{
    internal class Program
    {
        #region Fields
        private static readonly string[] _Addresses = new string[50];
        private static TrezorManagerBroker _TrezorManagerBroker;
        #endregion

        #region Main
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Waiting for Trezor... Please plug it in if it is not connected.");
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
        private static async Task<TrezorManager> ConnectAsync()
        {
            //This only needs to be done once.
            //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x / Trezor Model T
            WindowsUsbDeviceFactory.Register();

            //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
            WindowsHidDeviceFactory.Register();

            _TrezorManagerBroker = new TrezorManagerBroker(GetPin, 2000, new DefaultCoinUtility());
            return await _TrezorManagerBroker.WaitForFirstTrezorAsync();
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private static async Task Go()
        {
            try
            {
                using (var trezorManager = await ConnectAsync())
                {
                    Console.WriteLine("Trezor connection recognized");

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

                    while (true)
                    {
                        await Task.Delay(5000);                        
                        Console.WriteLine($"Count of connected Trezors: {_TrezorManagerBroker.TrezorManagers.Count}");
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
