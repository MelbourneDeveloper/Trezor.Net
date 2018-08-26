
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trezor.Net.UWPUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var text = App.PinTextBox.Text;
        }
    }
}
