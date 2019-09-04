using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class JobUpgrade
    {
        public int price = 0;
        public int quantity = 0;
        public int healthGain = 0;
        public int hungerGain = 0;
        public int jobUpgrade = 0;
        public string upgradeDescription;
        public class SharpStick : JobUpgrade
        {
            public SharpStick()
            {
                price = 10;
                quantity = 8;
                jobUpgrade = 0;
                upgradeDescription = "Just a slightly sharpened stick";
            }
        }
        public class WoodenSword : JobUpgrade
        {
            public WoodenSword()
            {
                price = 10;
                quantity = 8;
                jobUpgrade = 0;
                upgradeDescription = "Just a sharp stick shaped like a sword";
            }
        }
        public class StoneSword : JobUpgrade
        {
            public StoneSword()
            {
                price = 10;
                quantity = 8;
                jobUpgrade = 0;
                upgradeDescription = "A regular sword";
            }
            //public override double 
        }
    }
}
