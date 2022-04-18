using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lev_helloproj_library
{
    public static class Utils
    {
        public static void PrintInfoLev(int homework_Number, string FIO)
        {
            Console.WriteLine($"Домашняя работа номер {homework_Number}");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine($"Подаван : {FIO}");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            
        }
    }
}
