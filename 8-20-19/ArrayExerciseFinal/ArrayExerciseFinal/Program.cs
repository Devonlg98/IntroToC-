using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExerciseFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayFiller = 0;
            int[] data = new int[10];
            for(int i = 0; i < 10; i++)
            {
                data[i] = arrayFiller;
                arrayFiller++;
                Console.WriteLine(data[i]+1);

            }
            for(int i = 9; i > -1; --i)
            {
                data[i] = arrayFiller;
                arrayFiller--;
                Console.WriteLine(data[i]);
            }

            Console.ReadLine();
        }
    }

}
