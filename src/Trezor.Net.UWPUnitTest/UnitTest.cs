using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Trezor.Net
{
    [TestClass]
    public partial class UnitTest
    {
        private static TrezorManager TrezorManager;
        private static readonly string[] _Addresses = new string[50];

        [TestMethod]
        public async Task GetBitcoinAddress()
        {
            await GetAndInitialize();
            var address = await GetAddress(0, 0, true);
        }

        [TestMethod]
        public async Task GetBitcoinCashAddress()
        {
            await GetAndInitialize();
            var address = await GetAddress(145, 0, true);
        }

        [TestMethod]
        public async Task GetPublicKey()
        {
            await GetAndInitialize();
            var address = await TrezorManager.GetPublicKeyAsync("BTC", 0);
        }

        [TestMethod]
        public async Task TestThreadSafety()
        {
            await GetAndInitialize();

            var tasks = new List<Task>();

            for (uint i = 0; i < 50; i++)
            {
                tasks.Add(DoGetAddress(TrezorManager, i));
            }

            await Task.WhenAll(tasks);

            for (uint i = 0; i < 50; i++)
            {
                var address = await GetAddress(0, i, false);

                Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                if (address != _Addresses[i])
                {
                    throw new Exception("The ordering got messed up");
                }
            }
        }

        private static async Task<string> GetAddress(uint coinNumber, uint i, bool display)
        {
            return await TrezorManager.GetAddressAsync(true, coinNumber, 0, false, i, display, AddressType.Bitcoin);
        }

        private async Task GetAndInitialize()
        {
            if (TrezorManager != null)
            {
                return;
            }

            var trezorHidDevice = await Connect();
            TrezorManager = new TrezorManager(GetPin, trezorHidDevice);
            await TrezorManager.InitializeAsync();
        }

        private static async Task DoGetAddress(TrezorManager trezorManager, uint i)
        {
            var address = await GetAddress(0, i, false);
            _Addresses[i] = address;
        }
    }
}
