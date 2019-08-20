using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
                DoSomething(args[0]);
            else
                DoSomething("Dave");
            Console.ReadLine();
        }
        static void DoSomething(string _val)
        {
            Console.WriteLine($"Hello {_val}");
        }
    }
}
