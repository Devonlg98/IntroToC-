using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespaces silo your code so you can be sure
//than things like Class names don't clash with
//other peoples code in larger proejcts.
namespace Television
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Television Project");

            //First we need to create an instance of our Television class
            Television myTV = new Television();
            
            //The next line and the 2 commented lines following
            //demonstrate 3 differente ways of embedding variable content
            //into a string.
            //$"This approach to embedding {VARIABLENAME} is the latest."
            Console.WriteLine($"The current channel is {myTV.channel()}");
            //Console.WriteLine("The current channel is " + myTV.channel() );
            //Console.WriteLine("The current channel is {0}", myTV.channel());

            //First lets play with the current channel
            myTV.increaseChannel();
            Console.WriteLine($"The current channel is {myTV.channel()}");
            myTV.increaseChannel();
            myTV.increaseChannel();
            myTV.increaseChannel();
            Console.WriteLine($"The current channel is {myTV.channel()}");
            
            //And now play with the volume
            myTV.increaseVolume();
            Console.WriteLine($"The current volume is {myTV.volume()}");
            myTV.increaseVolume();
            myTV.increaseVolume();
            myTV.increaseVolume();
            Console.WriteLine($"The current volume is {myTV.volume()}");

            Console.ReadKey();
        }
    }
}
