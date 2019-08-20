using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int age2 = 0;
            Int32.TryParse(age, out age2);

            if (age2 < 18)
            {
                Console.WriteLine("You are a minor");
            }
            else if (!(age2<18||age2>49))
            {
                Console.WriteLine("You are an adult");
            }
            if (!(age2<50||age2>64))
            {
                Console.WriteLine("You are eligible to join AARP");
            }
            if (age2>64)
            {
                Console.WriteLine("You are eligible for retirement benefits");
            }
            Console.ReadLine();
        }
    }
}
