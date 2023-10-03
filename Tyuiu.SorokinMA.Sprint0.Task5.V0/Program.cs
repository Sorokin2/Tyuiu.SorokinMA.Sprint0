using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SorokinMA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A / B = " + DataService.Division(4, 0));
            Console.ReadKey();
        }
    }
}
