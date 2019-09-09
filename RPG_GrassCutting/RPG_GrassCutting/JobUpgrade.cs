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
        public float jobUpgrade = 0;
        public string upgradeDescription;
        public class SharpStick : JobUpgrade
        {
            public SharpStick()
            {
                price = 10;
                jobUpgrade = 1.2f;
                upgradeDescription = "Just a slightly sharpened stick";
            }
        }
        public class WoodenSword : JobUpgrade
        {
            public WoodenSword()
            {
                price = 25;
                jobUpgrade = 1.5f;
                upgradeDescription = "Just a sharp stick shaped like a sword";
            }
        }
        public class StoneSword : JobUpgrade
        {
            public StoneSword()
            {
                price = 50;
                jobUpgrade = 2f;
                upgradeDescription = "A regular sword";
            }
            //public override double 
        }
        //Note to self add MasterSword and HylianLawnMower
    }
}
