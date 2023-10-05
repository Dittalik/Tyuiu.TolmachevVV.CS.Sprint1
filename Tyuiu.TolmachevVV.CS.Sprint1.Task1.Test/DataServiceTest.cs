using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task1.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, DataService.Calc(3, 3, 3));
        }
    }
}
