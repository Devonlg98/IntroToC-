using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1994;
            do
            {
                counter++;
                Console.WriteLine(counter);
            } while (counter < 2017);
            Console.ReadKey();
        }
    }
}
