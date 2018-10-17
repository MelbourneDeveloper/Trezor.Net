using Hardwarewallets.Net;
using Hardwarewallets.Net.AddressManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trezor.Net.Contracts.Ethereum;

namespace Trezor.Net
{
    [TestClass]
    public partial class UnitTest
    {
        private static TrezorManager TrezorManager;
        private static readonly string[] _Addresses = new string[50];

        private static async Task<string> GetAddressAsync(uint index)
        {
            return await GetAddressAsync(true, 0, false, index, false);
        }

        private static Task<string> GetAddressAsync(bool isSegwit, uint coinNumber, bool isChange, uint index, bool display, string coinName = null, bool isPublicKey = false)
        {
            var addressPath = new AddressPath(isSegwit, coinNumber, 0, isChange, index);
            return TrezorManager.GetAddressAsync(addressPath, isPublicKey, display);
        }

        [TestMethod]
        public async Task DisplayBitcoinAddress()
        {
            await GetAndInitialize();
            var address = await GetAddressAsync(true, 0, false, 0, true);
        }

        [TestMethod]
        public async Task GetBitcoinAddress()
        {
            await GetAndInitialize();
            var address = await GetAddressAsync(true, 0, false, 0, false);
        }

        [TestMethod]
        public async Task GetBitcoinAddresses()
        {
            await GetAndInitialize();

            var addressManager = new AddressManager(TrezorManager, new AddressPathFactory(true, 0));

            //Get 10 addresses with all the trimming
            const int numberOfAddresses = 3;
            const int numberOfAccounts = 2;
            var addresses = await addressManager.GetAddressesAsync(0, numberOfAddresses, numberOfAccounts, true, true);

            Assert.IsTrue(addresses != null);
            Assert.IsTrue(addresses.Accounts != null);
            Assert.IsTrue(addresses.Accounts.Count == numberOfAccounts);
            Assert.IsTrue(addresses.Accounts[0].Addresses.Count == numberOfAddresses);
            Assert.IsTrue(addresses.Accounts[1].Addresses.Count == numberOfAddresses);
            Assert.IsTrue(addresses.Accounts[0].ChangeAddresses.Count == numberOfAddresses);
            Assert.IsTrue(addresses.Accounts[1].ChangeAddresses.Count == numberOfAddresses);
            Assert.IsTrue(addresses.Accounts[0].Addresses[0].PublicKey.Length > addresses.Accounts[0].Addresses[0].Address.Length);
        }

        [TestMethod]
        public async Task GetBitcoinCashAddress()
        {
            await GetAndInitialize();
            var address = await GetAddressAsync(false, 145, false, 0, false);
        }

        [TestMethod]
        public async Task DisplayBitcoinCashAddress()
        {
            await GetAndInitialize();
            //Coin name must be specified when displaying the address for most coins
            var address = await GetAddressAsync(false, 145, false, 0, true, "Bcash");
        }

        [TestMethod]
        public async Task DisplayEthereumAddress()
        {
            await GetAndInitialize();
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 60, false, 0, true);
        }

        [TestMethod]
        public async Task DisplayEthereumClassicAddress()
        {
            await GetAndInitialize();
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 61, false, 0, true);
        }

        [TestMethod]
        public async Task TestThreadSafety()
        {
            await GetAndInitialize();

            var tasks = new List<Task>();

            for (uint i = 0; i < 50; i++)
            {
                tasks.Add(DoGetAddress(i));
            }

            await Task.WhenAll(tasks);

            for (uint i = 0; i < 50; i++)
            {
                var address = await GetAddressAsync(i);

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

            //Note: these are not reasonable values. They should not be used for a transaction. Looking for a better example here...
            var txMessage = new EthereumSignTx
            {
                Nonce = 0.ToHexBytes(),
                GasPrice = 1000000000.ToHexBytes(),
                GasLimit = 21000.ToHexBytes(),
                To = "689c56aef474df92d44a1b70850f808488f9769c".ToHexBytes(),
                Value = 100000000000000.ToHexBytes(),
                AddressNs = ManagerHelpers.GetAddressPath(false, 0, false, 0, 60),
                ChainId = 4
            };

            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage);

            Assert.AreEqual(transaction.SignatureR.Length, 32);
            Assert.AreEqual(transaction.SignatureS.Length, 32);
        }

        [TestMethod]
        public async Task GetBitcoinCashCoinInfo()
        {
            var defaultCoinUtility = new DefaultCoinUtility();
            var bitcoinCashCoinInfo = defaultCoinUtility.GetCoinInfo(145);
            Assert.IsTrue(bitcoinCashCoinInfo.CoinName == "Bcash");
        }

        private async Task GetAndInitialize()
        {
            if (TrezorManager != null)
            {
                return;
            }

            var trezorHidDevice = await Connect();
            TrezorManager = new TrezorManager(GetPin, trezorHidDevice, new DefaultCoinUtility());
            await TrezorManager.InitializeAsync();
        }

        private static async Task DoGetAddress(uint i)
        {
            var address = await GetAddressAsync(i);
            _Addresses[i] = address;
        }
    }
}
