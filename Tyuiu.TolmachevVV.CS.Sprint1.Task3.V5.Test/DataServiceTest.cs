using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task3.V5.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DistCheck()
        {
            DataService service1 = new DataService();

            Assert.AreEqual(9.333, service1.DistanceLength(120, 0.077775));
        }
    }
}
