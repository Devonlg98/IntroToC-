using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionTeach2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Television Project");
            Television myTV = new Television();
            Console.WriteLine($"The current channel is {myTV.channel()}");
            myTV.increaseChannel();
            Console.ReadKey();
        }
    }
}
