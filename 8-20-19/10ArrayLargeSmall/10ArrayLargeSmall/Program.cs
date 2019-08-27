using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExerciseFinal
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
            Write wr = new Write();
            Console.WriteLine("Please Write 10 numbers, 1 per line");
            int[] data = new int[10];
            string arrayHolder;
            int arrayPlacer = 0;
            for (int i = 0; i < 10; i++) // Fills array with User input
            {
                arrayHolder = wr.Ask($"Please write your number {i+1} >");
                Int32.TryParse(arrayHolder, out arrayPlacer);
                data[i] = arrayPlacer;
            }

            int largNum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > largNum)
                {
                    largNum = data[i];
                }
            }

            int smallNum = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < smallNum)
                {
                    smallNum = data[i];
                }
            }
            Console.WriteLine($"The largest number you typed was {smallNum}.");
            Console.WriteLine($"The largest number you typed was {largNum}.");
            Console.ReadKey();
        }
    }

}
