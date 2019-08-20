using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inCombat = false;
            int playerHealth = 100;
            int monsterHealth = 50;
            string battleStartText = "The battle has begun!";
            string playerHealthText = "The player's health = " + playerHealth + ".";
            string monsterHealthText = "The monster's health = " + monsterHealth + ".";
            Console.WriteLine(playerHealthText);
            Console.WriteLine(monsterHealthText);
            Console.WriteLine(battleStartText);
            Console.ReadKey();
        }
    }
}
