using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Game
    {
        int playerHealth = 100;
        int monsterDamage = 30;
        public void Start()
        {
            Console.WriteLine("My game has begun!");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttacks(monsterDamage * 2);
            MonsterAttacks(monsterDamage);
            MonsterAttacks(monsterDamage *3);
        }
        private void MonsterEncounter()
        {
            Console.WriteLine("A vicious monster appears!");
            Console.ReadKey();
        }
        private void MonsterAttacks(int damage)
        {
            playerHealth -= damage;
            Console.WriteLine("The monster attacks you for " + damage + " points of damage.You have "+ playerHealth +  " health left.");
            Console.ReadKey();
        }
    }
}
