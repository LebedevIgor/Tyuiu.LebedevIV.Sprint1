using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task3.V19.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double x2 = 8.0;
            double y1 = 1.0;
            double y2 = 8.0;
            var res = ds.ElephCanMove(x1,x2,y1,y2);
            Assert.AreEqual(true, res);
        }
    }
}
