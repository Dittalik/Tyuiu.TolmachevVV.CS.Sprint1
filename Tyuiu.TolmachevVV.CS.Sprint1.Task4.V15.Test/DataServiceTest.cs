using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task4.V15.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateCheck()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(427851.058, service1.Calculate(2.123, 3.123));
        }
    }
}
