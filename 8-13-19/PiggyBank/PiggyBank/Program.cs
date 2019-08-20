using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    // Manages a digital money store that can only be deposited.
    // The balance may not be withdrawn without retrieving the full value.
    class DigitalPiggyBank
    {
        // Maintains the current balance of the piggy bank.
        private float currentBalance;

        // Add funds to the value of the current balance.
        public void deposit(float net)
        {
            currentBalance += net;
        }

        // Returns and clears the total current balance.
        public float withdraw() //float means we need to return, and set the balance to zero because its a withdraw
        {
            float tmpCurrrentBalance = currentBalance;
            currentBalance = 0;
            return tmpCurrrentBalance;
        }

        // Returns the current balance of the function.
        public float balance()
        {
            return currentBalance;
        }
        static void Main(string[] args)
        {
            DigitalPiggyBank dpb = new DigitalPiggyBank();
            dpb.deposit(50);
            Console.WriteLine(dpb.balance());
            dpb.deposit(75);
            Console.WriteLine(dpb.balance());
            float cashInHand = dpb.withdraw();
            Console.WriteLine(cashInHand);
            Console.ReadKey();
        }
    }
};

