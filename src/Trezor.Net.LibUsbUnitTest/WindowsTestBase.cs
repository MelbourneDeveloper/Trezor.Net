using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Trezor.Net
{
    public abstract class WindowsTestBase : UnitTestBase
    {
        #region Platform Specific Overrides
        protected string GetExecutingAssemblyDirectoryPath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var executingAssemblyDirectoryPath = Path.GetDirectoryName(uri.Path);
            return executingAssemblyDirectoryPath;
        }

        protected override async Task<string> GetPin()
        {
            var passwordExePath = Path.Combine(GetExecutingAssemblyDirectoryPath(), "Misc", "GetPassword.exe");
            if (!File.Exists(passwordExePath))
            {
                throw new Exception($"The pin exe doesn't exist at passwordExePath {passwordExePath}");
            }

            var asdasd = new ProcessStartInfo { FileName = @"C:\GitRepos\Trezor.Net\src\Trezor.Net.UnitTest\Misc\GetPassword.exe", WindowStyle= ProcessWindowStyle.Maximized, CreateNoWindow= false, UseShellExecute=true };
            var process = Process.Start(asdasd);
            //var asdasd = Process.Start(@"C:\GitRepos\Trezor.Net\src\Trezor.Net.UnitTest\Misc\GetPassword.exe");

            //var process = Process.Start(passwordExePath);
            //process.StartInfo.RedirectStandardOutput = false;
            //process.StartInfo.RedirectStandardError = false;
            ////var buffer = new char[1000];
            //////await process.StandardError.ReadAsync(buffer, 0, 1000);
            ////await process.StandardOutput.ReadAsync(buffer, 0, 1000);
            process.WaitForExit();
            //await Task.Delay(5000);
            var pin = File.ReadAllText(Path.Combine(GetExecutingAssemblyDirectoryPath(), "pin.txt"));
            return pin;
        }
        #endregion
    }
}
