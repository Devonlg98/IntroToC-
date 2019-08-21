using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3arraygrid
{
    class Write
    {
        public string Ask(string _val)
        {
            Console.WriteLine(_val);
            return Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int arraySlider = 1;
            int[,] map = new int[3, 3];
            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; ++col)
                {
                    map[row, col] = arraySlider;
                    arraySlider++;
                }
                Console.WriteLine($"Row {row+1} {map[row, 0]} {map[row, 1]} {map[row, 2]}");
            }
            Console.ReadKey();
        }
    }
}
