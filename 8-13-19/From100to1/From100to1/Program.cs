using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From100to1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 101;
            while (counter > 1)
            {
                counter--;
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
