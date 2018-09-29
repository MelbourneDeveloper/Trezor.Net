﻿using Hardwarewallets.Net.AddressManagement;
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

        private static async Task<string> GetAddress(uint index)
        {
            return await GetAddressAsync(true, 0, false, index, false);
        }

        private static async Task<string> GetAddressAsync(bool isSegwit, uint coinNumber, bool isChange, uint index, bool display, string coinName = null)
        {
            var addressPath = new AddressPath(isSegwit, coinNumber, 0, isChange, index);

            throw new NotImplementedException();
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
            var address = await GetAddressAsync(false, 145, 0, false, 0, true, "Bcash");
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
                tasks.Add(DoGetAddress(TrezorManager, i));
            }

            await Task.WhenAll(tasks);

            for (uint i = 0; i < 50; i++)
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

            //Note: these are not reasonable values. They should not be used for a transaction. Looking for a better example here...
            var txMessage = new EthereumSignTx
            {
                Nonce = "0".ToHexBytes(),
                GasPrice = 1000000000.ToHexBytes(),
                GasLimit = 21000.ToHexBytes(),
                To = "689c56aef474df92d44a1b70850f808488f9769c".ToHexBytes(),
                Value = "de0b6b3a7640000".ToHexBytes(),
                AddressNs = ManagerHelpers.GetAddressPath(false, 0, false, 0, 60),
                ChainId = 1
            };

            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage);

            Assert.AreEqual(transaction.SignatureR.Length, 32);
            Assert.AreEqual(transaction.SignatureS.Length, 32);
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

        private static async Task DoGetAddress(TrezorManager trezorManager, uint i)
        {
            var address = await GetAddress(i, false);
            _Addresses[i] = address;
        }

        //private CoinType GetCoinType(uint coinNumber)
        //{
        //    switch (coinNumber)
        //    {
        //        case 0:
        //            return new CoinType { CoinName = "Bitcoin", Segwit = true };
        //        case 145:
        //            return new CoinType { CoinName = "Bcash", Segwit = true };
        //        case 60:
        //        case 61:
        //            return new CoinType { CoinName = "Ethereum", Segwit = false };
        //    }

        //    throw new NotImplementedException();
        //}
    }
}
