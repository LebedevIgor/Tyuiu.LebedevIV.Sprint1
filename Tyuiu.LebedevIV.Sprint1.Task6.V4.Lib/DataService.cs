using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LebedevIV.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            string[] stringArray = value.Split(' ');
            string result = "";

            for (int i = 0; i < stringArray.Length; i++)
            {
                string word = stringArray[i];
                for (int index = 0; index < word.Length - 1; index++)
                {
                    if (word[index] == 'н' && word[index] == word[index + 1])
                    {
                        result += word + " ";
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                return result.TrimEnd();
            }

            return null;
        }
    }
}
