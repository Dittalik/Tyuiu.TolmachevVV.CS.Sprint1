using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.CS.Sprint1.Task2.V14.Lib;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Алгоритмы линейной структуры                                       *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #14                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите температуру в градусах Кельвина:                                  *");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.ConvertKelvinToCelsius(a) + "                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
