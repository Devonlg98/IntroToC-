using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise819
{
    class Program
    {
        static string MyName;

        static void MyPrinter(string _var)
        {
            Console.WriteLine(_var);
            Console.WriteLine(MyName);
            MyName = "bob";
        }
        static void Main(string[] args) // static can only be ran on the class
        {
            MyPrinter("hello world");

            Console.ReadKey();
        }
    }
}
