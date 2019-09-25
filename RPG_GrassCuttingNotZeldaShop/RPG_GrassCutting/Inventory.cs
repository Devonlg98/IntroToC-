using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    public class Inventory
    {
        public int price = 0;
        public int healthGain = 0;
        public int hungerGain = 0;
        public string foodString;
        public bool slotFilled = false;

        public Inventory(int v1, int v2, int v3, string v4, bool v5)
        {
            this.price = v1;
            this.healthGain = v2;
            this.hungerGain = v3;
            this.foodString = v4;
            this.slotFilled = v5;
        }
    }
}
