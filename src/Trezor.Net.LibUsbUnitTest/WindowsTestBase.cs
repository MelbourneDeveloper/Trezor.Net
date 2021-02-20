using Device.Net;
using Hid.Net.Windows;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Usb.Net.Windows;

#pragma warning disable CA2201 // Do not raise reserved exception types

namespace Trezor.Net
{
    //Why are there two WindowsTestBase classes?

    public abstract class WindowsTestBase : UnitTestBase
    {
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder => _ = builder.AddDebug().SetMinimumLevel(LogLevel.Trace));

        public WindowsTestBase() : base(TrezorManager.DeviceDefinitions.CreateWindowsHidDeviceFactory()
    .Aggregate(TrezorManager.DeviceDefinitions.CreateWindowsUsbDeviceFactory()), _loggerFactory)
        {

        }

        #region Platform Specific Overrides
        protected static string GetExecutingAssemblyDirectoryPath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var executingAssemblyDirectoryPath = Path.GetDirectoryName(uri.Path);
            return executingAssemblyDirectoryPath;
        }

        protected override Task<string> GetPin() => GetTextFromUI();

        protected override Task<string> GetPassphrase() => GetTextFromUI();

        private static Task<string> GetTextFromUI()
        => Task.Run(() =>
        {
            var passwordExePath = Path.Combine(GetExecutingAssemblyDirectoryPath(), "Misc", "GetPassword.exe");
            if (!File.Exists(passwordExePath))
            {
                throw new Exception($"The pin exe doesn't exist at passwordExePath {passwordExePath}");
            }

            var processStartInfo = new ProcessStartInfo
            {
                FileName = passwordExePath,
                UseShellExecute = true
            };

            var process = Process.Start(processStartInfo);

            process.WaitForExit();
            return File.ReadAllText(Path.Combine(GetExecutingAssemblyDirectoryPath(), "pin.txt"));
        });

        #endregion
    }
}
