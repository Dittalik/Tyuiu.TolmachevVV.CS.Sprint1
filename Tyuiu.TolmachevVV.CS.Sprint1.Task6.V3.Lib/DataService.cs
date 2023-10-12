using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TolmachevVV.CS.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string answ = "";
            String[] words = value.Split(' ');
            for (int i = 0; i < words.Length; ++i)
            {
                answ += words[i].Last();
            }
            return answ;
        }
    }
}
