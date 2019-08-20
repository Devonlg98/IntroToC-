using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromXtoY
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xy = new string[2];
            Console.WriteLine("Hi there! Please enter any number and then a number larger than the first");
            Console.WriteLine("Enter the low number now");
            xy[0] = Console.ReadLine();
            int x = 0;
            Int32.TryParse(xy[0], out x);


            Console.WriteLine($" Your first number is {xy[0]}, now enter a larger number");
            xy[1] = Console.ReadLine();
            int y = 0;
            Int32.TryParse(xy[1], out y);

            Console.WriteLine("Lowest");

            while (x < y)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine(x);
            Console.WriteLine("Highest");
            Console.ReadKey();



        }
    }
}
