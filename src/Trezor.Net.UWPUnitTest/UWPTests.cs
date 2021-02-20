using Device.Net;
using Hid.Net.UWP;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Trezor.Net.UWPUnitTest;
using Usb.Net.UWP;

namespace Trezor.Net
{
    [TestClass]
    public class UWPTests : UnitTestBase
    {
        public UWPTests() : base(
            TrezorManager.DeviceDefinitions.CreateUwpHidDeviceFactory(_loggerFactory)
            .Aggregate(TrezorManager.DeviceDefinitions.CreateUwpHidDeviceFactory(_loggerFactory)), _loggerFactory)
        {
        }

        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));

        protected override async Task<string> GetPin()
        {
            var pinCompletionSource = new TaskCompletionSource<string>();
            App.PinSelected += (a, b) =>
            {
                pinCompletionSource.SetResult(App.Pin);
            };
            var pin = await pinCompletionSource.Task.ConfigureAwait(false);
            return pin;
        }

        protected override Task<string> GetPassphrase() => throw new System.NotImplementedException();
    }
}
