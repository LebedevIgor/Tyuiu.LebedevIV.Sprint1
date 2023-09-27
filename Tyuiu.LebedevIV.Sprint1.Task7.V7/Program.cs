using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LebedevIV.Sprint1.Task7.V7.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Лебедев И.В. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Лебедев Игорь Владимирович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем. Ответ округлите   *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("*        cos x                                                            *");
            Console.WriteLine("* z = -------------- + 16 * x * cos (x * y) - 2                           *");
            Console.WriteLine("*      PI - 2 * y^x                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите x ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите y ");
            double y = Convert.ToDouble(Console.ReadLine());
            var result = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($" z = {result}");
            Console.ReadKey();
        }
    }
}
