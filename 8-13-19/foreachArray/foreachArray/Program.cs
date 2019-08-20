using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachArray
{
    class Program
    {
        static void Main(string[] args)
        {//[] makes it an array
            string[] dogNames = { "bonzo", "fred", "killer", "arnold", "benji", "lassie" };
            
            foreach (String str in dogNames)
            {  // if you break point line 17, you can view the array of dogs in a list
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
