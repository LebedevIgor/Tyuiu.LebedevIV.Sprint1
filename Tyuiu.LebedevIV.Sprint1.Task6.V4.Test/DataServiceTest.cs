using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint1.Task6.V4.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "Сестра угостила меня лимонным соком 17 апреля будет для меня торжественный день";
            var res = ds.CheckDoubleN(a);
            Assert.AreEqual("лимонным торжественный", res);
        }
    }
}
