using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[4] { 1, 2, 3, 4, };
            int sumTotal = 0;
            for (int i = 0; i < 4; i++)
            {
                sumTotal += someArray[i];
                Console.WriteLine(sumTotal);
            }

            Console.ReadKey();
        }
    }
}
