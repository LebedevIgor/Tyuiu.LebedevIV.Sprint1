using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task1.V24.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 2.0;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(0, res);
        }
    }
}
