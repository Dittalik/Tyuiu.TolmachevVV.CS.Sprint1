using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task1.Lib
{
    public class DataService
    {
        public static int Calc(int a, int b, int c)
        {
            return a * b * c / (a + b + c);
        }
    }
}
