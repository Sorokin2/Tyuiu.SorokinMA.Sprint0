using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SorokinMA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(7, 5));
            Console.WriteLine(DataService.Subtraction(13, 5));
            Console.WriteLine(DataService.Multiplication(4, 6));
            Console.WriteLine(DataService.Division(5, 4));
            Console.ReadKey();
        }
    }
}
