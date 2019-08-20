using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberJudging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write a number between 1 and 100");
            String num = Console.ReadLine();
            int num2 = 0;
            Int32.TryParse(num, out num2);
            
            if (num2 < 50)
            {
                Console.WriteLine("The number is small");
            }
            else if (num2 > 50)
            {
                Console.WriteLine("The number is large");
            }
            else if (num2 == 50)
            {
                Console.WriteLine("That's a balanced number");
            }            
            Console.ReadLine();
        }
    }
}
