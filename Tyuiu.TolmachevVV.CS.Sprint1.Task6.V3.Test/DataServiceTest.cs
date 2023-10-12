using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.CS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LastLetterWord()
        {
            DataService service1 = new DataService();
            Assert.AreEqual("кпрлолд", service1.LastLetterWord("кцк пцп рцр ваол аволо вфыджл вылд"));
        }
    }
}
