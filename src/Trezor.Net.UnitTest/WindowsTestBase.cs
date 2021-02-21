using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Device.Net;
using Hid.Net.Windows;
using Microsoft.Extensions.Logging;
using Usb.Net.Windows;

namespace Trezor.Net
{
    public abstract class WindowsTestBase : UnitTestBase
    {
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));

        public WindowsTestBase() : base(TrezorManager.DeviceDefinitions.CreateWindowsHidDeviceFactory(_loggerFactory)
            .Aggregate(TrezorManager.DeviceDefinitions.CreateWindowsUsbDeviceFactory(_loggerFactory)), _loggerFactory)
        {

        }

        #region Platform Specific Overrides
        protected string GetExecutingAssemblyDirectoryPath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var executingAssemblyDirectoryPath = Path.GetDirectoryName(uri.Path);
            return executingAssemblyDirectoryPath;
        }

        protected override async Task<string> GetPin() => await Prompt("Pin").ConfigureAwait(false);

        private async Task<string> Prompt(string prompt)
        {
            var passwordExePath = Path.Combine(GetExecutingAssemblyDirectoryPath(), "Misc", "GetPassword.exe");
            if (!File.Exists(passwordExePath))
            {
                throw new Exception($"The pin exe doesn't exist at passwordExePath {passwordExePath}");
            }
            var process = Process.Start(new ProcessStartInfo(passwordExePath, prompt) { UseShellExecute = true });
            process.WaitForExit();
            await Task.Delay(100).ConfigureAwait(false);
            var pin = File.ReadAllText(Path.Combine(GetExecutingAssemblyDirectoryPath(), "pin.txt"));
            return pin;
        }

        protected override Task<string> GetPassphrase() => Prompt("Passphrase");
        #endregion
    }
}
