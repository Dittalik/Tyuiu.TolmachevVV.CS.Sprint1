using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task0.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        public void CalculateCheck()
        {
            DataService service1 = new DataService();

            Assert.AreEqual(-12, service1.Calculate());
        }
    }
}
