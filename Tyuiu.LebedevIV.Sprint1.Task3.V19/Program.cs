using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LebedevIV.Sprint1.Task3.V19.Lib;

namespace Tyuiu.LebedevIV.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Лебедев И.В. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Лебедев Игорь Владимирович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости       *");
            Console.WriteLine("* с одного заданного поля шахматной доски перейти за один ход на другое.  *");
            Console.WriteLine("* Пользователь задаёт координаты двух ячеек шахматной доски               *");
            Console.WriteLine("* (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).                       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите координату x1 (дробное число от 1 до 8) ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите координату x2 (дробное число от 1 до 8) ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите координату y1 (дробное число от 1 до 8) ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите координату y2 (дробное число от 1 до 8) ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var res = ds.ElephCanMove(x1, x2, y1, y2) == true ? "True - Такой путь возможен" : "False - Такой путь не возможен";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"x1={x1}, x2={x2}, y1={y1}, y2={y2} | {res}.");
            Console.ReadKey();
        }
    }
}
