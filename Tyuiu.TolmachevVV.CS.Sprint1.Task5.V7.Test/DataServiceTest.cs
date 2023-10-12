using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void AngelToHours()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(8, service1.AngleToHoursMinutes(240.123));
        }
    }
}
