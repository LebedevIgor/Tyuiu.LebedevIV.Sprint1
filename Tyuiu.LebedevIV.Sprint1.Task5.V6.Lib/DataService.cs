using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LebedevIV.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int firstDayOfWeek = 1; 

            int remainder = (k - 1) % 7;

            int dayOfWeek = (firstDayOfWeek + remainder) % 7;

            int n = 0;
            switch (dayOfWeek)
            {
                case 0: n = 7; break; 
                case 1: n = 1; break; 
                case 2: n = 2; break; 
                case 3: n = 3; break; 
                case 4: n = 4; break; 
                case 5: n = 5; break; 
                case 6: n = 6; break; 
            }
            return n;
        }
    }
}
