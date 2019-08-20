using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter < 10)
            {
                counter++;
                Console.WriteLine($"Counter is equal to {counter}");

            }
            Console.ReadLine();
        }
    }
}
