using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitMovementStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int size = 1;
            int[] binaryArray = new int[size];
            Int32.TryParse(Console.ReadLine(), out input);
            //do
            //{
            //    size++;

            //    if (input %2 == 0)
            //    {
            //        binaryArray[size-1] = 0;
            //    }
            //    else
            //    {
            //        binaryArray[size-1] = 1;
            //    }
            //    input /= 2;
            //} while (input > 0);
            for(int i = 0; input > 0; i++)
            {
                if (input % 2 == 0)
                {
                    binaryArray[i] = 0;
                }
                else
                {
                    binaryArray[i] = 1;
                }
                input /= 2;
            }
            for (int i = 0; i<size; i++)
            {
                Console.Write(binaryArray[i]);
            }
            Console.ReadKey();
        }
    }
}
