using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetContainerExercise
{
    class Program
    {

        public static int[] array123 = new int[] { 1, 2, 3 };
        public static int array456 = 10;

        class Write
        {
            public string Ask(string _val)
            {
                Console.WriteLine(_val);
                return Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            {
                Write wr = new Write();
                string className;
                className = wr.Ask("Name your class >");
                ArrayExample(array456);
                Test(array123);
                Console.ReadKey();
            }
        }
        public static void ArrayExample(int size) // static makes it easier to call, but I can't adjust values from outside such as the array
        {

            int[] array = new int[size];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = 1;
            //    Console.WriteLine(array[i]);
            //}
            foreach (int i in array)
            {
                array[i] = array[i] + 1;
                Console.WriteLine(array[i]);
            }
        }
        public static void Test(int[] bob)
        {
            ArrayExample(10);
        }

    }
}
