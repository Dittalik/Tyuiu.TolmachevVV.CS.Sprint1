using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task1.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(1, service1.Calculate(3, 3));
        }
    }
}
