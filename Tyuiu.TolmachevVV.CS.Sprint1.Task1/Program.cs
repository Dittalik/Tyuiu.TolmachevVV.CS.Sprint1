using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.CS.Sprint1.Task1.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Алгоритмы линейной структуры                                       *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #29                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите переменную a:                                                     *");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b:                                                     *");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную c:                                                     *");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(DataService.Calc(a, b, c) + "                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
