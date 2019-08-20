using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] number = new string[3];
            Console.WriteLine("Howdyho! What are your favorite numbers?");
            Console.WriteLine("What's the first number?");
            number[0]= Console.ReadLine();
            Console.WriteLine($"Okay, your first number is {number[0]}. What's the second number?");
            number[1] = Console.ReadLine();
            Console.WriteLine($"Okay, your favorites have been {number[0]} and {number[1]}. What's the third number?");
            number[2] = Console.ReadLine();
            Console.WriteLine($"Okay, your favorite numbers are {number[0]}, {number[1]}, {number[2]}.");
            Console.ReadKey();
        }
    }
}
