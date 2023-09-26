using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LebedevIV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Лебедев И.В. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс ConvertФайл                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Лебедев Игорь Владимирович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение      *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели (понедельник,     *");
            Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года,       *");
            Console.WriteLine("* в котором 1 января – понедельник.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите день от 1 до 365 ");
            int k = Convert.ToInt32(Console.ReadLine());
            var res = ds.Calculate(k);
            string dayOfName = "";
            switch (res)
            {
                case 1: dayOfName = "Суббота"; break;
                case 2: dayOfName = "Понедельник"; break;
                case 3: dayOfName = "Вторник"; break;
                case 4: dayOfName = "Среда"; break;
                case 5: dayOfName = "Четверг"; break;
                case 6: dayOfName = "Пятница"; break;
                case 7: dayOfName = "Воскресенье"; break;
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{dayOfName}({res}) - ваш день недели");
            Console.ReadKey();
        }
    }
}
