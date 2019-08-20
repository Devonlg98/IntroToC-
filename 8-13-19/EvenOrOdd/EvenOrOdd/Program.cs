using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number and I'll tell you if it's even or odd");
            string input = Console.ReadLine();
            int output = 0;
            Int32.TryParse(input, out output);

            if (output % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if (output % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
        }

    }
}
