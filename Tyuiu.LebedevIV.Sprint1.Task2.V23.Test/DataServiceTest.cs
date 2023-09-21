using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task2.V23.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minute = 1;
            var res = ds.ConvertMinutesToSeconds(minute);
            Assert.AreEqual(60, res);
        }
    }
}
