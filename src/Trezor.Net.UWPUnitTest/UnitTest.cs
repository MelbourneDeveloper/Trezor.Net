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
        public async Task GetAddress()
        {
            await GetAndInitialize();
            var address = await GetAddress(0, true);
        }

        [TestMethod]
        public async Task TestThreadSafety()
        {
            await GetAndInitialize();

            var tasks = new List<Task>();

            for (var i = 0; i < 50; i++)
            {
                tasks.Add(DoGetAddress(TrezorManager, i));
            }

            await Task.WhenAll(tasks);

            for (var i = 0; i < 50; i++)
            {
                var address = await GetAddress(i, false);

                Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                if (address != _Addresses[i])
                {
                    throw new Exception("The ordering got messed up");
                }
            }
        }

        [TestMethod]
        public async Task SignEthereumTransaction()
        {
            await GetAndInitialize();

            var txMessage = new EthereumSignTx
            {
                Nonce = 0.ToHexBytes(),
                GasPrice = 1000.ToHexBytes(),
                GasLimit = 21000.ToHexBytes(),
                To = "689c56aef474df92d44a1b70850f808488f9769c".ToHexBytes(),
                Value = 1000.ToHexBytes(),
                AddressNs = ManagerHelpers.GetAddressPath(false, 0, false, 0, 60),
            };

            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage);

            Assert.AreEqual(transaction.SignatureR.Length, 32);
            Assert.AreEqual(transaction.SignatureS.Length, 32);
        }

        private static async Task<string> GetAddress(int i, bool display)
        {
            return await TrezorManager.GetAddressAsync("BTC", 0, false, (uint)i, display, AddressType.Bitcoin);
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

        private static async Task DoGetAddress(TrezorManager trezorManager, int i)
        {
            var address = await GetAddress(i, false);
            _Addresses[i] = address;
        }
    }
}
