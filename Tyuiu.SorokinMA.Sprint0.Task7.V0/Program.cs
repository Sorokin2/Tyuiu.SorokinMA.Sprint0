using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinMA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.SorokinMA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i<arrayNums1.Length;i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();
            int[] arrayNums2 = new int[] { 2, 3, 4, 5, 6 };
            for (int i = 0; i<arrayNums2.Length;i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }
            Console.WriteLine();
            if (arrayNums1.Length==arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                for(int i = 0;i<resultArray.Length;i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! У массивов разны длины");
            }
            Console.ReadKey();
        }
    }
}
