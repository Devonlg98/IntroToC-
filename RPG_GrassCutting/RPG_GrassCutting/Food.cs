using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{

    public class Food
    {
        public int price = 0;
        public int quantity = 0;
        public int healthGain = 0;
        public int hungerGain = 0;
        public string[] foodString = new string[4];
        //public string fs2;

        public Food(int v1, int v2, int v3, int v4, string v5)
        {
            this.price = v1;
            this.quantity = v2;
            this.healthGain = v3;
            this.hungerGain = v4;
            this.foodString[0] = v5;
        }

        public Food (int kind)
        {
            //1= pizza. 2=lettuce,3=apple
            switch (kind)


            {
                case 1:
                    price = 15;
                    quantity = 8;
                    healthGain = 0;
                    hungerGain = 2;
                    foodString[0] = ($"Pizza \r\n" +
                         $"Price : {price} \r\n" +
                         $"Quanity : {quantity} \r\n" +
                         $"Health Gain : {healthGain} \r\n" +
                         $"Hunger Gain : {hungerGain}");
                    break;
                case 2:
                    price = 15;
                    quantity = 3;
                    healthGain = 0;
                    hungerGain = 3;
                    foodString[1] = ($"Lettuce \r\n" +
                        $"Price : {price} \r\n" +
                        $"Quanity : {quantity} \r\n" +
                        $"Health Gain : {healthGain} \r\n" +
                        $"Hunger Gain : {hungerGain}");
                    break;

                case 3:
                    price = 15;
                    quantity = 2;
                    healthGain = 1;
                    hungerGain = 2;
                    foodString[2] = ($"Apple \r\n" +
                        $"Price : {price} \r\n" +
                        $"Quanity : {quantity} \r\n" +
                        $"Health Gain : {healthGain} \r\n" +
                        $"Hunger Gain : {hungerGain}");

                    break;

                default:
                    break;
            }

        }
    }
    //public class Pizza : Food
    //{
    //    public Pizza()
    //    {
    //        price = 10;
    //        quantity = 8;
    //        healthGain = 0;
    //        hungerGain = 2;
    //        foodString[0] = ($"Pizza \r\n" +
    //             $"Price : {price} \r\n" +
    //             $"Quanity : {quantity} \r\n" +
    //             $"Health Gain : {healthGain} \r\n" +
    //             $"Hunger Gain : {hungerGain}");
    //    }

    //}
    //public class Lettuce : Food
    //{
    //    public Lettuce()
    //    {
    //        price = 15;
    //        quantity = 3;
    //        healthGain = 0;
    //        hungerGain = 3;
    //        foodString[0] = ($"Lettuce \r\n" +
    //            $"Price : {price} \r\n" +
    //            $"Quanity : {quantity} \r\n" +
    //            $"Health Gain : {healthGain} \r\n" +
    //            $"Hunger Gain : {hungerGain}");
    //    }
    //}
    //public class Apple : Food
    //{
    //    public Apple()
    //    {
    //        price = 15;
    //        quantity = 2;
    //        healthGain = 1;
    //        hungerGain = 2;
    //        foodString[0] = ($"Apple \r\n" +
    //            $"Price : {price} \r\n" +
    //            $"Quanity : {quantity} \r\n" +
    //            $"Health Gain : {healthGain} \r\n" +
    //            $"Hunger Gain : {hungerGain}");

    //    }
    //    //public override double 
    //}
}
