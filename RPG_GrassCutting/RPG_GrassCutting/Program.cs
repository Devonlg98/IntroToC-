﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GrassCutting
{
    class Program
    {

        class Read
        {
            public string Ask(string _val)
            {
                Console.WriteLine(_val);

                return Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            //Food pz = new Pizza(); 
            //Food lt = new Lettuce();
            //Food ap = new Apple();
            Player pl = new Player();
            JobUpgrade jb = new JobUpgrade();
            JobUpgrade.SharpStick jbshs = new JobUpgrade.SharpStick();
            JobUpgrade.WoodenSword jbwos = new JobUpgrade.WoodenSword();
            JobUpgrade.StoneSword jbsts = new JobUpgrade.StoneSword();
            Random rd = new Random();
            Read re = new Read();
            // 1 2 or 3 for each case
            Food pz1 = new Food(3, 8, 0, 2, ($"Pizza Slice"));
            // Assigns the value of v1 price v2 quanity etc etc
            Food dt1 = new Food(2, 12, 0, 1, ("Donut"));
            Food bs1 = new Food(6, 2, 1, 6, ("BLT Sammy"));
            Food[] foodArray = new Food[3] { pz1, dt1, bs1 };
            int foodRandomizer = rd.Next(0, 3);
            JobUpgrade[] jobArray = new JobUpgrade[3] {jbshs, jbwos, jbsts};
            int currentWeapon = 1;
            bool goHome = true;
            bool goBack = true;
            bool gameOn = true;

            while(gameOn == true)
            {
                while (goHome == true)
                {
                    goBack = true;
                    Console.Clear();
                    Console.WriteLine($"Rupees = {pl.rupees}");
                    string buysellrentask = re.Ask("Welcome to my shop mighty traveler \r\nWould you like to Buy[1], Sell[2], Rent[3]?, go Home[g]? or quit [q] >");
                    int buysellrent = 0;
                    Int32.TryParse(buysellrentask, out buysellrent);
                    switch (buysellrentask)
                    {
                        case "g":
                            goHome = false;
                            break;

                        case "G":
                            goHome = false;
                            break;

                        case "q":
                            gameOn = false;
                            break;

                        case "Q":
                            gameOn = false;
                            break;

                        default:
                            while (goBack == true)
                            {
                                switch (buysellrent)
                                {
                                    //Case for buying
                                    case 1:
                                        Console.Clear();

                                        Console.WriteLine($"Rupees = {pl.rupees}");

                                        Console.WriteLine("Here is what I have available for today!");
                                        Console.WriteLine($"{foodArray[foodRandomizer].foodString}[1]\r\nFood2[2]\r\nFood3[3]\r\nor back to store front[b]");
                                        string foodAsk = re.Ask("What would you like to do? >");
                                        if (foodAsk == "b" || foodAsk == "b")
                                        {
                                            goBack = false;
                                            break;
                                        }
                                        int foodSure = 0;
                                        Int32.TryParse(foodAsk, out foodSure);

                                        switch (foodSure)
                                        {   //Food 1
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine($"Rupees = {pl.rupees}");
                                                string purchaseAsk = re.Ask($"{foodArray[foodRandomizer].foodString}\r\n" +
                                                $"Price : {foodArray[foodRandomizer].price} \r\n" +
                                                $"Quanity : {foodArray[foodRandomizer].quantity} \r\n" +
                                                $"Health Gain : {foodArray[foodRandomizer].healthGain} \r\n" +
                                                $"Hunger Gain : {foodArray[foodRandomizer].hungerGain}\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");

                                                if ((purchaseAsk == "y" || purchaseAsk == "Y") && foodArray[foodRandomizer].quantity > 0)
                                                {
                                                    foodArray[foodRandomizer].quantity -= 1;
                                                    pl.rupees -= foodArray[foodRandomizer].price;
                                                    Console.WriteLine($"Rupees = {pl.rupees}");

                                                }
                                                break;
                                            //Food 2
                                            case 2:

                                                break;
                                            //Food 3
                                            case 3:

                                                break;
                                        }
                                        break;

                                    //Case for selling
                                    case 2:

                                        break;
                                    //Case for renting
                                    case 3:

                                        break;
                                }
                            }
                            continue;
                    }
                    break;
                }

                if(gameOn == false)
                {
                    Console.Clear();
                    Console.WriteLine("Saving...\r\nNow Exiting.");
                    break;
                }
                int foundRupees = (rd.Next(1, 10) * currentWeapon);
                pl.rupees += foundRupees;
                Console.Clear();
                Console.WriteLine($"Rupees = {pl.rupees}");
                Console.WriteLine($"You head home, sleep, wake up, cut grass and find {foundRupees} Rupees\r\nPress Any Key To Continue >");
                Console.ReadKey();
                goHome = true;
            }


            //foodFix[0] = pz.foodString[0];
            //foodFix[1] = lt.foodString[0];
            //foodFix[2] = ap.foodString[0];

            //Console.WriteLine($"{pz.foodString[0]} \r\n {lt.foodString[1]} \r\n {ap.foodString[2]} ");
            //Console.WriteLine($"{foodFix[0]} \r\n \r\n{foodFix[1]} \r\n \r\n{foodFix[2]}");
            //Console.WriteLine(ap1.foodString);
            //Console.WriteLine(pz1.foodString[0]);
            //Console.WriteLine(lt1.foodString[0]);
            //Console.WriteLine(ap1.foodString[0]);
            Console.ReadKey();
        }
    }
}
