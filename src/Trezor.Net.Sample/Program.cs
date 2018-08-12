using Hid.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trezor;
using Trezor.Net;

namespace TrezorTestApp
{
    class Program
    {
        #region Fields
        private static readonly string[] _Addresses = new string[50];
        #endregion

        #region Main
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
        #endregion

        #region Private  Methods
        private static async Task<IHidDevice> Connect()
        {
            var devices = WindowsHidDevice.GetConnectedDeviceInformations();
            var trezors = devices.Where(d => d.VendorId == TrezorManager.TrezorVendorId && TrezorManager.TrezorProductId == 1);

            DeviceInformation trezorDeviceInformation;

            trezorDeviceInformation = trezors.FirstOrDefault(t => t.Product == TrezorManager.USBOneName);

            if (trezorDeviceInformation == null)
            {
                throw new Exception("No Trezor is not connected or USB access was not granted to this application.");
            }

            var retVal = new WindowsHidDevice(trezorDeviceInformation);

            await retVal.InitializeAsync();

            return retVal;
        }

        /// <summary>
        /// TODO: This should be made in to a unit test but it's annoying to add the UI for a unit test as the Trezor requires human intervention for the pin
        /// </summary>
        /// <returns></returns>
        private async static Task Go()
        {
            try
            {
                using (var trezorHid = await Connect())
                {
                    using (var trezorManager = new TrezorManager(GetPin, trezorHid))
                    {
                        await trezorManager.InitializeAsync();

                        //var tasks = new List<Task>();

                        //for (var i = 0; i < 50; i++)
                        //{
                        //    tasks.Add(DoGetAddress(trezorManager, i));
                        //}

                        //await Task.WhenAll(tasks);

                        //for (var i = 0; i < 50; i++)
                        //{
                        //    var address = await GetAddress(trezorManager, i);

                        //    Console.WriteLine($"Index: {i} (No change) - Address: {address}");

                        //    if (address != _Addresses[i])
                        //    {
                        //        throw new Exception("The ordering got messed up");
                        //    }
                        //}

                        var ethAddress = await trezorManager.GetAddressAsync("ETH", 60, false, 0, false, AddressType.Ethereum);
                        Console.WriteLine($"First ETH address: {ethAddress}");

                        var txMessage = new EthereumSignTx
                        {
                            AddressNs = ManagerHelpers.GetAddressPath(false, 0, false, 0, 60),
                            GasLimit = Encoding.Unicode.GetBytes("98bca5a00"),
                            GasPrice = Encoding.Unicode.GetBytes("a3ff"),
                            To = Encoding.Unicode.GetBytes("0xdc7359317ef4cc723a3980213a013c0433a33891"),
                            Nonce = Encoding.Unicode.GetBytes("01"),
                            Value = Encoding.Unicode.GetBytes("0x1"),
                        };

                        var transaction = await trezorManager.SendMessageAsync<EthereumSignMessage, EthereumSignTx>(txMessage);

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

        private async static Task DoGetAddress(TrezorManager trezorManager, int i)
        {
            var address = await GetAddress(trezorManager, i);
            _Addresses[i] = address;
        }

        private static async Task<string> GetAddress(TrezorManager trezorManager, int i)
        {
            return await trezorManager.GetAddressAsync("BTC", 0, false, (uint)i, false, AddressType.Bitcoin);
        }

        private async static Task<string> GetPin()
        {
            Console.WriteLine("Enter PIN based on Trezor values: ");
            return Console.ReadLine().Trim();
        }
        #endregion
    }
}
