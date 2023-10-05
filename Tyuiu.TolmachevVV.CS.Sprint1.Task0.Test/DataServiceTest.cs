using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task0.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(13, DataService.Calc(10, 9, 3));
        }
    }
}
