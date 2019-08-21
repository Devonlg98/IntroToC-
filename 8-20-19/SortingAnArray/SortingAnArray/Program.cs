using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[5] { 23, 42, 1, 2, 3 };
            Array.Sort(someArray);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(someArray[i]);
            }
            Console.WriteLine("reverse");
            for (int i = 4; i > -1; --i)
            {
                Console.WriteLine(someArray[i]);
            }

            Console.ReadKey();


        }
    }
}
