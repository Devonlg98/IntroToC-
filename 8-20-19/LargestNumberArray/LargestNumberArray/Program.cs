using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int largNum = 0;
            int[] numbers = new int[6] { 52, -1, 55, 100, 17, 8 };
            for (int i = 0; i < 6; i++)
            {
                if (numbers[i] > largNum)
                {
                    largNum = numbers[i];
                }
            }
            Console.WriteLine(largNum);
            Console.ReadKey();

        }

    }

}