using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task2.V14.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertCheck()
        {
            DataService service1 = new DataService();

            Assert.AreEqual(1, service1.ConvertKelvinToCelsius(274));
        }
    }
}
