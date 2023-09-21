using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LebedevIV.Sprint1.Task2.V23.Lib
{
    public class DataService : ISprint1Task2V23
    {
        public int ConvertMinutesToSeconds(int value)
        {
            return value * 60;
        }
    }
}
