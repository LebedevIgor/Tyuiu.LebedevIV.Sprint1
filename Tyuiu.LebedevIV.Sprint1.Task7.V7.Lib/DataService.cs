using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LebedevIV.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((Math.Cos(x) / Math.PI - 2 * Math.Pow(y, x)) + 16 * x * Math.Cos(x * y) - 2), 3);
        }
    }
}
