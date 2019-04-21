using Hardwarewallets.Net;
using Hardwarewallets.Net.AddressManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.RLP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;
using Trezor.Net.Contracts.Bitcoin;
using Trezor.Net.Contracts.Ethereum;
using Trezor.Net.Manager;

namespace Trezor.Net
{
    [TestClass]
    public abstract partial class UnitTestBase
    {
        #region Fields
        //This must remain static for persistenance across tests
        protected static TrezorManager TrezorManager;
        private readonly string[] _Addresses = new string[50];
        private TrezorManagerBroker _TrezorManagerBroker;
        #endregion

        #region Protected Abstract Methods
        protected abstract Task<string> GetPin();
        protected abstract Task<string> GetPassphrase();
        #endregion

        #region Protected Virtual Methods
        protected virtual async Task<TrezorManager> ConnectAsync()
        {
            _TrezorManagerBroker = new TrezorManagerBroker(GetPin, GetPassphrase, 2000, new DefaultCoinUtility());
            return await _TrezorManagerBroker.WaitForFirstTrezorAsync();
        }
        #endregion

        #region Helpers
        private async Task<string> GetAddressAsync(uint index)
        {
            return await GetAddressAsync(true, 0, false, index, false);
        }

        private async Task<string> GetAddressAsync(uint coinNumber, bool display)
        {
            var coinInfo = TrezorManager.CoinUtility.GetCoinInfo(coinNumber);
            var address = await GetAddressAsync(coinInfo.IsSegwit, coinInfo.CoinType, false, 0, display);
            return address;
        }

        private async Task<string> GetAddressAsync(bool isSegwit, uint coinNumber, bool isChange, uint index, bool display, string coinName = null, bool isPublicKey = false)
        {
            var addressPath = new BIP44AddressPath(isSegwit, coinNumber, 0, isChange, index);
            var firstAddress = await TrezorManager.GetAddressAsync(addressPath, isPublicKey, display);
            var addressPathString = $"m/{(isSegwit ? 49 : 44)}'/{coinNumber}'/{(isChange ? 1 : 0)}'/{0}/{index}";
            var secondAddress = await GetAddressAsync(addressPathString);

            Assert.IsTrue(firstAddress == secondAddress, "The parsed version of the address path yielded a different result to the non-parsed version");

            return secondAddress;
        }

        private async Task<string> GetAddressAsync(string addressPath, bool display = false, string coinName = null, bool isPublicKey = false)
        {
            var bip44AddressPath = AddressPathBase.Parse<BIP44AddressPath>(addressPath);

            //TODO: Duplicate code here
            var address = await TrezorManager.GetAddressAsync(bip44AddressPath, isPublicKey, display);
            Assert.IsTrue(!string.IsNullOrEmpty(address), $"The address was null or empty. Path: {addressPath}");
            Console.WriteLine(address);
            return address;
        }

        private async Task DoGetAddress(uint i)
        {
            var address = await GetAddressAsync(i);
            _Addresses[i] = address;
        }
        #endregion

        #region Setup / Teardown
        [TestInitialize]
        public async Task GetAndInitializeAsync()
        {
            if (TrezorManager != null)
            {
                return;
            }

            TrezorManager = await ConnectAsync();
        }

        [TestCleanup]
        public void Cleanup()
        {
            //TODO: We should dispose of the TrezorManager here, but this is called after every test...
            //TrezorManager.Dispose();
        }
        #endregion

        #region Tests
        /// <summary>
        /// Special thanks to https://github.com/ljupko123
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task SignBitcoinTransactionAsync()
        {
            //get address path for address in Trezor
            var addressPath = AddressPathBase.Parse<BIP44AddressPath>("m/49'/0'/0'/0/0").ToArray();

            // previous unspent input of Transaction
            var txInput = new TxAck.TransactionType.TxInputType()
            {
                AddressNs = addressPath,
                Amount = 100837,
                ScriptType = InputScriptType.Spendp2shwitness,
                PrevHash = "3becf448ae38cf08c0db3c6de2acb8e47acf6953331a466fca76165fdef1ccb7".ToHexBytes(), // transaction ID
                PrevIndex = 0,
                Sequence = 4294967293 // Sequence  number represent Replace By Fee 4294967293 or leave empty for default 
            };

            // TX we want to make a payment
            var txOut = new TxAck.TransactionType.TxOutputType()
            {
                AddressNs = new uint[0],
                Amount = 100837,
                Address = "18UxSJMw7D4UEiRqWkArN1Lq7VSGX6qH3H",
                ScriptType = TxAck.TransactionType.TxOutputType.OutputScriptType.Paytoaddress // if is segwit use Spendp2shwitness

            };

            // Must be filled with basic data like below
            var signTx = new SignTx()
            {
                Expiry = 0,
                LockTime = 0,
                CoinName = "Bitcoin",
                Version = 2,
                OutputsCount = 1,
                InputsCount = 1
            };

            // For every TX request from Trezor to us, we response with TxAck like below
            var txAck = new TxAck()
            {
                Tx = new TxAck.TransactionType()
                {
                    Inputs = { txInput }, // Tx Inputs
                    Outputs = { txOut },   // Tx Outputs
                    Expiry = 0,
                    InputsCnt = 1, // must be exact number of Inputs count
                    OutputsCnt = 1, // must be exact number of Outputs count
                    Version = 2
                }
            };

            // If the field serialized.serialized_tx from Trezor is set,
            // it contains a chunk of the signed transaction in serialized format.
            // The chunks are returned in the right order and just concatenating all returned chunks will result in the signed transaction.
            // So we need to add chunks to the list
            var serializedTx = new List<byte>();

            // We send SignTx() to the Trezor and we wait him to send us Request
            var request = await TrezorManager.SendMessageAsync<TxRequest, SignTx>(signTx);

            // We do loop here since we need to send over and over the same transactions to trezor because his 64 kilobytes memory
            // and he will sign chunks and return part of signed chunk in serialized manner, until we receive finall type of Txrequest TxFinished
            while (request.request_type != TxRequest.RequestType.Txfinished)
            {
                switch (request.request_type)
                {
                    case TxRequest.RequestType.Txinput:
                        {
                            //We send TxAck() with  TxInputs
                            request = await TrezorManager.SendMessageAsync<TxRequest, TxAck>(txAck);

                            // Now we have to check every response is there any SerializedTx chunk 
                            if (request.Serialized != null)
                            {
                                // if there is any we add to our list bytes
                                serializedTx.AddRange(request.Serialized.SerializedTx);
                            }

                            break;
                        }
                    case TxRequest.RequestType.Txoutput:
                        {
                            //We send TxAck()  with  TxOutputs
                            request = await TrezorManager.SendMessageAsync<TxRequest, object>(txAck);

                            // Now we have to check every response is there any SerializedTx chunk 
                            if (request.Serialized != null)
                            {
                                // if there is any we add to our list bytes
                                serializedTx.AddRange(request.Serialized.SerializedTx);
                            }

                            break;
                        }

                    case TxRequest.RequestType.Txextradata:
                        {
                            // for now he didn't ask me for extra data :)
                            break;
                        }
                    case TxRequest.RequestType.Txmeta:
                        {
                            // for now he didn't ask me for extra Tx meta data :)
                            break;
                        }
                }
            }

            Debug.WriteLine($"TxSignature: {serializedTx.ToArray().ToHexCompact()}");
        }

        [TestMethod]
        public async Task GetCardanoAddress()
        {
            var address = await GetAddressAsync(1815, false);
        }


        [TestMethod]
        public async Task GetNamecoinAddress()
        {
            var address = await GetAddressAsync(7, false);
        }

        [TestMethod]
        public async Task DisplayBitcoinAddress()
        {
            var address = await GetAddressAsync(0, true);
        }

        [TestMethod]
        public async Task GetBitcoinAddress()
        {
            var address = await GetAddressAsync(true, 0, false, 0, false);
        }

        [TestMethod]
        public async Task GetBitcoinAddresses()
        {
            var addressManager = new AddressManager(TrezorManager, new BIP44AddressPathFactory(true, 0));

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
            var address = await GetAddressAsync(false, 145, false, 0, false);
        }

        [TestMethod]
        public async Task GetBitcoinCashParsedAddress()
        {
            var address = await GetAddressAsync("m/44'/145'/0'/0/0");
        }

        [TestMethod]
        public async Task DisplayBitcoinCashAddress()
        {
            var address = await GetAddressAsync(false, 145, false, 0, true, "Bcash");
        }

        [TestMethod]
        public async Task GetBitcoinGoldAddress()
        {
            var address = await GetAddressAsync(156, false);
        }

        [TestMethod]
        public async Task DisplayEthereumAddress()
        {
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 60, false, 0, true);
        }

        [TestMethod]
        public async Task GetEthereumAddress()
        {
            var address = await GetAddressAsync("m/44'/60'/0'/1/0");
        }

        [TestMethod]
        public async Task GetEthereumClassicAddressParsed()
        {
            var address = await GetAddressAsync("m/44'/61'/0'/1/0");
        }

        [TestMethod]
        public async Task GetEthereumClassicAddress()
        {
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 61, false, 0, false);
        }

        [TestMethod]
        public async Task TestThreadSafety()
        {
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
            //Note: these are not reasonable values. They should not be used for a transaction. Looking for a better example here...
            var txMessage = new EthereumSignTx
            {
                Nonce = 0.ToHexBytes(),
                GasPrice = 1000000000.ToHexBytes(),
                GasLimit = 21000.ToHexBytes(),
                To = "689c56aef474df92d44a1b70850f808488f9769c",
                Value = 100000000000000.ToHexBytes(),
                AddressNs = new BIP44AddressPath(false, 60, 0, false, 0).ToArray(),
                ChainId = 4
            };

            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage);

            Assert.AreEqual(transaction.SignatureR.Length, 32);
            Assert.AreEqual(transaction.SignatureS.Length, 32);
        }

        [TestMethod]
        public async Task SignEthereumTransaction2()
        {
            var txMessage = new EthereumSignTx
            {
                Nonce = 10.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                GasPrice = 1000000000.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                GasLimit = 21000.ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                To = "689c56aef474df92d44a1b70850f808488f9769c",
                Value = BigInteger.Parse("10000000000000000000").ToBytesForRLPEncoding().ToHex().ToHexBytes(),
                AddressNs = AddressPathBase.Parse<BIP44AddressPath>("m/44'/60'/0'/0/0").ToArray(),
                ChainId = 1
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
        #endregion
    }
}
