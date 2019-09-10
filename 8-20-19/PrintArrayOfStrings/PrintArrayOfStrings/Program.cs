using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int answer2 = 0;
            Console.WriteLine("When do you want it to stop?");
            answer = Console.ReadLine();
            Int32.TryParse(answer, out answer2);


            int[] someArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 9; i > answer2; --i)
            {
                Console.WriteLine( someArray[i]);
            }
            Console.WriteLine("Reverse");
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(someArray[i]);
            }

            Console.ReadKey();
        }

        //public static void Test(someArray[])
        //{

        //}
    }
}
