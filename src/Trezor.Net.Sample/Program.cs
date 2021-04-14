using Device.Net;
using Hardwarewallets.Net.AddressManagement;
using Hid.Net.Windows;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trezor.Net;
using Trezor.Net.Manager;

#pragma warning disable CA2201 // Do not raise reserved exception types

namespace TrezorTestApp
{
    internal class Program
    {
        #region Fields
        private static readonly string[] _Addresses = new string[50];
        private static TrezorManagerBroker _TrezorManagerBroker;
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));
        #endregion

        #region Main
        private static async Task Main()
        {
            try
            {
                Console.WriteLine("Waiting for Trezor... Please plug it in if it is not connected.");
                await Go().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _ = Console.ReadLine();
            }
        }
        #endregion

        #region Private  Methods
        private static async Task<TrezorManager> ConnectAsync()
        {
            var usbFactory = TrezorManager.DeviceDefinitions.CreateWindowsUsbDeviceFactory();
            var hidFactory = TrezorManager.DeviceDefinitions.CreateWindowsHidDeviceFactory();
            var aggregateFactory = usbFactory.Aggregate(hidFactory, _loggerFactory);


            _TrezorManagerBroker = new TrezorManagerBroker(GetPin, GetPassphrase, 2000, aggregateFactory, new DefaultCoinUtility(), _loggerFactory);
            return await _TrezorManagerBroker.WaitForFirstTrezorAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private static async Task Go()
        {
            try
            {
                using var trezorManager = await ConnectAsync().ConfigureAwait(false);

                Console.WriteLine("Trezor connection recognized");

                var tasks = new List<Task>();

                for (uint i = 0; i < 50; i++)
                {
                    tasks.Add(DoGetAddress(trezorManager, i));
                }

                await Task.WhenAll(tasks).ConfigureAwait(false);

                for (uint i = 0; i < 50; i++)
                {
                    var address = await GetAddress(trezorManager, i).ConfigureAwait(false);

                    Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                    if (address != _Addresses[i])
                    {
                        throw new Exception("The ordering got messed up");
                    }
                }

                var addressPath = new BIP44AddressPath(false, 60, 0, false, 0);

                var ethAddress = await trezorManager.GetAddressAsync(addressPath, false, false).ConfigureAwait(false);
                Console.WriteLine($"First ETH address: {ethAddress}");

                Console.WriteLine("All good");

                while (true)
                {
                    Console.WriteLine($"Count of connected Trezors: {_TrezorManagerBroker.TrezorManagers.Count}");
                    await Task.Delay(5000).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                _ = Console.ReadLine();
            }
        }

        private static async Task DoGetAddress(TrezorManager trezorManager, uint i)
        {
            var address = await GetAddress(trezorManager, i).ConfigureAwait(false);
            _Addresses[i] = address;
        }

        private static async Task<string> GetAddress(TrezorManager trezorManager, uint i) => await trezorManager.GetAddressAsync(new BIP44AddressPath(true, 0, 0, false, i), false, false).ConfigureAwait(false);

        private static Task<string> GetPin()
        => Task.Run(() =>
        {
            Console.WriteLine("Enter PIN based on Trezor values: ");
            return Console.ReadLine().Trim();
        });

        private static Task<string> GetPassphrase() => GetPin();

        #endregion
    }
}
