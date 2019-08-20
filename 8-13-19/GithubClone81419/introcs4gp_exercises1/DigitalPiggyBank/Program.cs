using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalPiggyBank dpb = new DigitalPiggyBank();
            dpb.deposit(50);
            Console.WriteLine(dpb.balance());
            dpb.deposit(75);
            Console.WriteLine(dpb.balance());
            float cashInHand=dpb.withdraw();
            Console.WriteLine(cashInHand);
            Console.ReadKey();
        }
    }
}
