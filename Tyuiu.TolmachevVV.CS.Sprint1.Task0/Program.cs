using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.CS.Sprint1.Task0.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 9;
            int z = 3;
            Console.Title = "Спринт #0 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Алгоритмы линейной структуры                                       *");
            Console.WriteLine("*Задание #1                                                               *");
            Console.WriteLine("*Вариант #20                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{x} + {y} / {z}                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(DataService.Calc(x, y, z) + "                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
