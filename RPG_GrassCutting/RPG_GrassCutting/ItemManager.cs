using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
        public class JFood
        {
            public int price = 0;
            public int quantity = 0;
            public int healthGain = 0;
            public int hungerGain = 0;
            public string foodString;

            public JFood(int v1, int v2, int v3, int v4, string v5)
            {
                this.price = v1;
                this.quantity = v2;
                this.healthGain = v3;
                this.hungerGain = v4;
                this.foodString = v5;
            }
        }

        //Healthy food
        public class HFood
        {
            public int price = 0;
            public int quantity = 0;
            public int healthGain = 0;
            public int hungerGain = 0;
            public string foodString;

            public HFood(int v1, int v2, int v3, int v4, string v5)
            {
                this.price = v1;
                this.quantity = v2;
                this.healthGain = v3;
                this.hungerGain = v4;
                this.foodString = v5;
            }
        }

        //Mystery food
        public class MFood
        {
            public int price = 0;
            public int quantity = 0;
            public int healthGain = 0;
            public int hungerGain = 0;
            public string foodString;

            public MFood(int v1, int v2, int v3, int v4, string v5)
            {
                this.price = v1;
                this.quantity = v2;
                this.healthGain = v3;
                this.hungerGain = v4;
                this.foodString = v5;
            }
        }
}
