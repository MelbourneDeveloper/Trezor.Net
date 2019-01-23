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

            var processStartInfo = new ProcessStartInfo
            {
                FileName = passwordExePath,
                WindowStyle = ProcessWindowStyle.Maximized,
                CreateNoWindow = false,
                UseShellExecute =true
            };

            var process = Process.Start(processStartInfo);
            process.WaitForExit();
            return File.ReadAllText(Path.Combine(GetExecutingAssemblyDirectoryPath(), "pin.txt"));
        }
        #endregion
    }
}
