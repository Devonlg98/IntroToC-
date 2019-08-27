using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intDays2DArray
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
            int[,] days = new int[29, 5];
            for (int row = 0; row < 29; row++)
            {
                for (int col = 0; col < 5; ++col)
                {
                    
                }
                Console.WriteLine("Next Row");
            }
            Console.ReadKey();
        }
    }
}
