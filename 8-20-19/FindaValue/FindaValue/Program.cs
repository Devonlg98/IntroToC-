using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindaValue
{
    class Program
    {   // Looking for entered value, if true, says so and return where it is in the array, if false return -1
        static void Main(string[] args)
        {
            int[] someArray = new int[5] { 23, 42, 1, 2, 3 };
            Console.WriteLine("Enter a number you are looking for");
            string findValue = Console.ReadLine();
            int findValueA = 0;
            Int32.TryParse(findValue, out findValueA);
            bool valueFound = false;
            int valueOut = 0;

            for (int i = 0; i < 5; i++)
            {
                if(someArray[i] == findValueA)
                {
                    valueFound = true;
                    valueOut = i;
                }
            }
            if(valueFound == true)
            {
                Console.WriteLine(valueOut);
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadKey();
        }
    }
}
