using Device.Net;
using Hardwarewallets.Net;
using Hardwarewallets.Net.AddressManagement;
using Microsoft.Extensions.Logging;
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
    //TODO: Put a LibUsb test back

    [TestClass]
    public abstract partial class UnitTestBase
    {
        IDeviceFactory deviceFactory;
        ILoggerFactory loggerFactory;

        protected UnitTestBase(IDeviceFactory deviceFactory, ILoggerFactory loggerFactory)
        {
            this.deviceFactory = deviceFactory;
            this.loggerFactory = loggerFactory;
        }

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
            _TrezorManagerBroker = new TrezorManagerBroker(GetPin, GetPassphrase, 2000, new DefaultCoinUtility(), deviceFactory, loggerFactory);
            return await _TrezorManagerBroker.WaitForFirstTrezorAsync().ConfigureAwait(false);
        }
        #endregion

        #region Helpers
        private async Task<string> GetAddressAsync(uint index) => await GetAddressAsync(true, 0, false, index, false).ConfigureAwait(false);

        private async Task<string> GetAddressAsync(uint coinNumber, bool display)
        {
            var coinInfo = TrezorManager.CoinUtility.GetCoinInfo(coinNumber);
            var address = await GetAddressAsync(coinInfo.IsSegwit, coinInfo.CoinType, false, 0, display).ConfigureAwait(false);
            return address;
        }

        private async Task<string> GetAddressAsync(bool isSegwit, uint coinNumber, bool isChange, uint index, bool display, string coinName = null, bool isPublicKey = false)
        {
            var addressPath = new BIP44AddressPath(isSegwit, coinNumber, 0, isChange, index);
            var firstAddress = await TrezorManager.GetAddressAsync(addressPath, isPublicKey, display).ConfigureAwait(false);
            var addressPathString = $"m/{(isSegwit ? 49 : 44)}'/{coinNumber}'/{(isChange ? 1 : 0)}'/{0}/{index}";
            var secondAddress = await GetAddressAsync(addressPathString).ConfigureAwait(false);

            Assert.IsTrue(firstAddress == secondAddress, "The parsed version of the address path yielded a different result to the non-parsed version");

            return secondAddress;
        }

        private async Task<string> GetAddressAsync(string addressPath, bool display = false, string coinName = null, bool isPublicKey = false)
        {
            var bip44AddressPath = AddressPathBase.Parse<BIP44AddressPath>(addressPath);

            //TODO: Duplicate code here
            var address = await TrezorManager.GetAddressAsync(bip44AddressPath, isPublicKey, display).ConfigureAwait(false);
            Assert.IsTrue(!string.IsNullOrEmpty(address), $"The address was null or empty. Path: {addressPath}");
            Console.WriteLine(address);
            return address;
        }

        private async Task DoGetAddress(uint i)
        {
            var address = await GetAddressAsync(i).ConfigureAwait(false);
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

            TrezorManager = await ConnectAsync().ConfigureAwait(false);
        }

        [TestCleanup]
        public void Cleanup()
        {
            //TODO: We should dispose of the TrezorManager here, but this is called after every test...
            //TrezorManager.Dispose();
        }
        #endregion

        #region Tests
        [TestMethod]
        public async Task SignBitcoinTransactionAsync()
        {
            //get address path for address in Trezor
            var addressPath = AddressPathBase.Parse<BIP44AddressPath>("m/49'/0'/0'/0/0").ToArray();

            // previous unspent inputs of Transaction
            var txInputs = new List<TxAck.TransactionType.TxInputType>()
            {
                new TxAck.TransactionType.TxInputType()
                {
                    AddressNs = addressPath,
                    Amount = 1790890,
                    ScriptType = InputScriptType.Spendp2shwitness,
                    PrevHash = "797ad8727ee672123acfc7bcece06bf648d3833580b1b50246363f3293d9fe20".ToHexBytes(), // transaction ID
                    PrevIndex = 0,
                    Sequence = 4294967293 // Sequence  number represent Replace By Fee 4294967293 or leave empty for default 
                }
            };

            // TX we want to make a payment
            var txOutputs = new List<TxAck.TransactionType.TxOutputType>()
            {
                new TxAck.TransactionType.TxOutputType()
                {
                    Amount = 50000,
                    Address = "34i58jxXbcjHbHmo1Pdzx8UjqLphZuG8c1",
                    ScriptType = TxAck.TransactionType.TxOutputType.OutputScriptType.Paytoaddress // always use Paytoaddress if Address is set
                },
                new TxAck.TransactionType.TxOutputType()
                {
                    Amount = 1790890 - 50000 - 1000,
                    // change output does not specify Address but uses AddressNs
                    AddressNs = AddressPathBase.Parse<BIP44AddressPath>("m/49'/0'/0'/1/0").ToArray(),
                    ScriptType = TxAck.TransactionType.TxOutputType.OutputScriptType.Paytop2shwitness // must match all inputs
                },
            };

            // Must be filled with basic data like below
            var signTx = new SignTx()
            {
                LockTime = 0,
                CoinName = "Bitcoin",
                Version = 2,
                InputsCount = (uint)txInputs.Count,
                OutputsCount = (uint)txOutputs.Count,
            };

            // Cache of previous transactions. This dictionary must contain an entry for every PrevHash used in the transaction inputs above.
            var prevTxes = new Dictionary<string, TxAck.TransactionType>
            {

                // Information taken from https://btc1.trezor.io/tx/797ad8727ee672123acfc7bcece06bf648d3833580b1b50246363f3293d9fe20
                // All the shown fields must be correctly filled out. For Bitcoin, others can be omitted.
                ["797ad8727ee672123acfc7bcece06bf648d3833580b1b50246363f3293d9fe20".ToUpper()] = new TxAck.TransactionType()
                {
                    Version = 1,
                    LockTime = 0,

                    Inputs =
                    {
                        new TxAck.TransactionType.TxInputType()
                        {
                            // address_n, script_type and amonout is unused in previous tx
                            PrevHash = "0757c4c6247bbd46f718e6944735d3c5047c5e6f8bf0150506b5347b680b5812".ToHexBytes(),
                            PrevIndex = 0,
                            ScriptSig = "16001438865742de45fc9617e754fe0e413d2c6ef30124".ToHexBytes(),
                            Sequence = 4294967295,
                        },
                    },
                    // For previous tx, BinOutputs are used instead of Outputs. They only have amount and script_pubkey.
                    BinOutputs =
                    {
                        new TxAck.TransactionType.TxOutputBinType()
                        {
                            Amount = 1790890,
                            ScriptPubkey = "00146d4100c05c93a8f2bd7c1342df587ec90cb0ec43".ToHexBytes(),
                        },
                        new TxAck.TransactionType.TxOutputBinType()
                        {
                            Amount = 1998443,
                            ScriptPubkey = "a914211b791fc53bad19ef17b3ddeeeb24e610a5ffd087".ToHexBytes(),
                        },
                    },
                }
            };

            // If the field serialized.serialized_tx from Trezor is set,
            // it contains a chunk of the signed transaction in serialized format.
            // The chunks are returned in the right order and just concatenating all returned chunks will result in the signed transaction.
            // So we need to add chunks to the list
            var serializedTx = new List<byte>();

            // We send SignTx() to the Trezor and we wait him to send us Request
            var request = await TrezorManager.SendMessageAsync<TxRequest, SignTx>(signTx).ConfigureAwait(false);

            // We do loop here since we need to send over and over the same transactions to trezor because his 64 kilobytes memory
            // and he will sign chunks and return part of signed chunk in serialized manner, until we receive finall type of Txrequest TxFinished
            bool running = true;
            while (running)
            {
                if (request.Serialized != null)
                {
                    // if there is any we add to our list bytes
                    serializedTx.AddRange(request.Serialized.SerializedTx);
                }

                // for clarity, use a new txAck object each time
                var txAck = new TxAck()
                {
                    Tx = new TxAck.TransactionType()
                };

                switch (request.request_type)
                {
                    case TxRequest.RequestType.Txinput:
                        {
                            var prevHash = request.Details.TxHash;
                            var prevIndex = (int)request.Details.RequestIndex;

                            if (prevHash != null)
                            {
                                // retrieve input from specified previous tx
                                var prevtx = prevTxes[prevHash.ToHexString()];
                                txAck.Tx.Inputs.Add(prevtx.Inputs[prevIndex]);
                            } else
                            {
                                // take one of the current transaction inputs
                                txAck.Tx.Inputs.Add(txInputs[prevIndex]);
                            }

                            request = await TrezorManager.SendMessageAsync<TxRequest, TxAck>(txAck).ConfigureAwait(false);
                            break;
                        }
                    case TxRequest.RequestType.Txoutput:
                        {
                            var prevHash = request.Details.TxHash;
                            var prevIndex = (int)request.Details.RequestIndex;

                            if (prevHash != null)
                            {
                                // retrieve **bin** output from specified previous tx
                                var prevtx = prevTxes[prevHash.ToHexString()];
                                txAck.Tx.BinOutputs.Add(prevtx.BinOutputs[prevIndex]);
                            }
                            else
                            {
                                // take one of the current transaction normal outputs
                                txAck.Tx.Outputs.Add(txOutputs[prevIndex]);
                            }

                            request = await TrezorManager.SendMessageAsync<TxRequest, object>(txAck).ConfigureAwait(false);
                            break;
                        }

                    case TxRequest.RequestType.Txextradata:
                        {
                            // This will never happen for Bitcoin.
                            // For Zcash, you need to pre-fill ExtraData and ExtraDataLen in the previous tx.
                            // This is somewhat complicated: basically, parse the raw transaction bytes up to Expiry field,
                            // and take all raw bytes beyond that.
                            // request.Details will contain offset and length, pick that chunk and put it into TransactionType.ExtraData that you send.
                            throw new NotImplementedException();
                        }
                    
                    case TxRequest.RequestType.Txmeta:
                        {
                            // This will only happen when txHash is set.
                            var prevtx = prevTxes[request.Details.TxHash.ToHexString()];
                            txAck.Tx = new TxAck.TransactionType()
                            {
                                Version = prevtx.Version,
                                LockTime = prevtx.LockTime,
                                InputsCnt = (uint)prevtx.Inputs.Count,
                                OutputsCnt = (uint)prevtx.BinOutputs.Count,
                            };
                            request = await TrezorManager.SendMessageAsync<TxRequest, object>(txAck).ConfigureAwait(false);
                            break;
                        }

                    case TxRequest.RequestType.Txfinished:
                        {
                            // stop the loop
                            running = false;
                            break;
                        }
                }
            }

            Debug.WriteLine($"TxSignature: {serializedTx.ToArray().ToHexCompact()}");
        }

        /// <summary>
        /// Note: I don't know how to verify if this is returning the correct address or not
        /// </summary>
        [TestMethod]
        public async Task DisplayStellarPublicKey()
        {
            var address = await GetAddressAsync("m/44'/148'/0'/0/0", true, null, true).ConfigureAwait(false);
        }

        /// <summary>
        /// Confirmed address valid as per online wallet
        /// </summary>
        [TestMethod]
        public async Task GetCardanoAddress()
        {
            var isModelT = string.Compare(TrezorManager.Features.Model, "T", StringComparison.OrdinalIgnoreCase) == 0;

            string address = null;
            try
            {
                address = await GetAddressAsync(1815, false).ConfigureAwait(false);
            }
            catch (NotSupportedException)
            {
                if (!isModelT) return;
            }

            if (isModelT)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(address));
            }
        }

        /// <summary>
        /// Confirmed address valid as per online wallet
        /// </summary>
        [TestMethod]
        public async Task GetTezosAddress()
        {
            var isModelT = string.Compare(TrezorManager.Features.Model, "T", StringComparison.OrdinalIgnoreCase) == 0;

            string address = null;
            try
            {
                address = await GetAddressAsync("44'/1729'/0'", false).ConfigureAwait(false);
            }
            catch (NotSupportedException)
            {
                if (!isModelT) return;
            }

            if (isModelT)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(address));
            }
        }

        /// <summary>
        /// Note: I don't know how to verify if this is returning the correct address or not
        /// </summary>
        [TestMethod]
        public async Task GetNEMAddress()
        {
            var address = await GetAddressAsync("44'/43'/0'", false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetNamecoinAddress()
        {
            var address = await GetAddressAsync(7, false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task DisplayBitcoinAddress()
        {
            var address = await GetAddressAsync(0, true).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetBitcoinAddress()
        {
            var address = await GetAddressAsync(true, 0, false, 0, false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetBitcoinAddresses()
        {
            var addressManager = new AddressManager(TrezorManager, new BIP44AddressPathFactory(true, 0));

            //Get 10 addresses with all the trimming
            const int numberOfAddresses = 3;
            const int numberOfAccounts = 2;
            var addresses = await addressManager.GetAddressesAsync(0, numberOfAddresses, numberOfAccounts, true, true).ConfigureAwait(false);

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
            var address = await GetAddressAsync(false, 145, false, 0, false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetBitcoinCashParsedAddress()
        {
            var address = await GetAddressAsync("m/44'/145'/0'/0/0").ConfigureAwait(false);
        }

        [TestMethod]
        public async Task DisplayBitcoinCashAddress()
        {
            var address = await GetAddressAsync(false, 145, false, 0, true, "Bcash").ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetBitcoinGoldAddress()
        {
            var address = await GetAddressAsync(156, false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task DisplayEthereumAddress()
        {
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 60, false, 0, true).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetEthereumAddress()
        {
            var address = await GetAddressAsync("m/44'/60'/0'/1/0").ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetEthereumClassicAddressParsed()
        {
            var address = await GetAddressAsync("m/44'/61'/0'/1/0").ConfigureAwait(false);
        }

        [TestMethod]
        public async Task GetEthereumClassicAddress()
        {
            //Ethereum coins don't need the coin name
            var address = await GetAddressAsync(false, 61, false, 0, false).ConfigureAwait(false);
        }

        [TestMethod]
        public async Task TestThreadSafety()
        {
            var tasks = new List<Task>();

            const int addresses = 20;

            for (uint i = 0; i < addresses; i++)
            {
                tasks.Add(DoGetAddress(i));
            }

            await Task.WhenAll(tasks).ConfigureAwait(false);

            for (uint i = 0; i < addresses; i++)
            {
                var address = await GetAddressAsync(i).ConfigureAwait(false);

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

            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage).ConfigureAwait(false);

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
            var transaction = await TrezorManager.SendMessageAsync<EthereumTxRequest, EthereumSignTx>(txMessage).ConfigureAwait(false);

            Assert.AreEqual(transaction.SignatureR.Length, 32);
            Assert.AreEqual(transaction.SignatureS.Length, 32);
        }

        [TestMethod]
        public void GetBitcoinCashCoinInfo()
        {
            var defaultCoinUtility = new DefaultCoinUtility();
            var bitcoinCashCoinInfo = defaultCoinUtility.GetCoinInfo(145);
            Assert.IsTrue(bitcoinCashCoinInfo.CoinName == "Bcash");
        }
        #endregion
    }
}
