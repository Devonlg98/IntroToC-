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
            int counter = 0;
            while (counter < 100)
            {
                counter++;
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
