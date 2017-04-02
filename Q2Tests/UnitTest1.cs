using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q2;

namespace Q2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Answer();
            int r = a.A();
            Assert.AreEqual(0, r);
        }
    }
}
