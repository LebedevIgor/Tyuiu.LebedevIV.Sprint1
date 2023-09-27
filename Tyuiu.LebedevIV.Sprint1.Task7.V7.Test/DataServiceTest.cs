using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task7.V7.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4.817, res);
        }
    }
}
