using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[5] { 23, 42, 1, 1, 3 };
            Console.WriteLine("Enter a number you are looking for");
            string findValue = Console.ReadLine();
            int findValueA = 0;
            Int32.TryParse(findValue, out findValueA);
            int countValue = 0;

            for (int i = 0; i < 5; i++)
            {
                if (someArray[i] == findValueA)
                {
                    countValue++;
                }
            }
            Console.WriteLine($"We found your number {countValue} times.");
            Console.ReadKey();

        }
    }
}
