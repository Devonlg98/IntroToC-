using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUniqueness
{
    class Program
    {
        static void Main(string[] args)
        {
            bool uniqueArray = true;
            int[] someArray = new int[5] { 1, 2, 3, 4, 5};
            Array.Sort(someArray); // sorts array in numerical order
            for (int i = 0; i < 4; i++) // compares a line in the array to the line above to check if they are the same
            {
                if (someArray[i] == someArray[i+1])
                {
                    uniqueArray = false;
                }
                
            }
            Console.WriteLine(uniqueArray);
            Console.ReadKey();
        }
    }
}
