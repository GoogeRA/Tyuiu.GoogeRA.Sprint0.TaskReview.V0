using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.GoogeRA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #0                                                  *");
            Console.WriteLine("* Тема: Создание итогового решения  по спринту               *");
            Console.WriteLine("* Задние #Review                                             *");
            Console.WriteLine("* Вариант #0                                                 *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать консольную программу на С#, которая вычисляет     *");
            Console.WriteLine("* выражение (X+Y+Z)*5.                                       *");
            Console.WriteLine("*                                                            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine(" ЗНАЧЕНИЕ ПЕРЕМННЫХ: X = 3, Y = 2, Z = 4                      ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("(X + Y + Z) * 5 = " + DataService.Calc(3, 2, 4));
            Console.ReadKey();




        }
    }
}
