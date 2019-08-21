using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = 0;
            int[] someArray = new int[6] { 5, 58, -3, 99, 65, 83 };
            for (int i =0; i < 6; i++)
            {
                if (someArray[i] < smallestNumber)
                {
                    smallestNumber = someArray[i];
                }
            }
            Console.WriteLine(smallestNumber);
            Console.ReadKey();
        }
    }
}
