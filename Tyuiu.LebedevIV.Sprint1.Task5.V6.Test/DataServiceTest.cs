using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 13;
            var res = ds.Calculate(k);
            Assert.AreEqual(6, res);
        }
    }
}
