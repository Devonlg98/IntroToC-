using System;
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
        class TryCatch
        {
            public bool runInvSort =  true;
            Player pl = new Player();
            public void JInventorySorter(Inventory[] v1, int v2,JFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();
                    //break; need to set this up as a boolean and then if bool true break

                }
                return;
            }

            public void HInventorySorter(Inventory[] v1, int v2, HFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();
                    //break; need to set this up as a boolean and then if bool true break

                }
                return;
            }

            public void MInventorySorter(Inventory[] v1, int v2, MFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();
                    //break; need to set this up as a boolean and then if bool true break

                }
                return;
            }
        }



        
        static void Main(string[] args)
        {
            TryCatch invSort = new TryCatch();
            
            //Food pz = new Pizza(); 
            //Food lt = new Lettuce();
            //Food ap = new Apple();
            Player pl = new Player();
            //JobUpgrade jb = new JobUpgrade();
            //JobUpgrade.SharpStick jbshs = new JobUpgrade.SharpStick();
            //JobUpgrade.WoodenSword jbwos = new JobUpgrade.WoodenSword();
            //JobUpgrade.StoneSword jbsts = new JobUpgrade.StoneSword();

            Random rd = new Random();
            Read re = new Read();
            int slotChecker = 0;
            int jfoodRandomizer = 0;
            int hfoodRandomizer = 0;
            int mfoodRandomizer = 0;
            int currentWeapon = 0;
            int goalDay = 0;
            int currentDay = 1;
            int multiplierRupee = 0;
            int foundRupees = 0;
            int use = 0;
            string goalDayAsked = "";
            string purchaseAsk;
            string useAsk;
            bool goHome = false;
            bool goBack = true;
            bool gameOn = true;
            Inventory[] inv = new Inventory[9];
            //Inventory slotFill = new Inventory(1, 1, 1, "N/A");
            //Inventory[] inventoryArray = new Inventory[] { };
            for (int i = 0; i < 9; i++)
            {
                inv[i] = new Inventory(0, 0, 0, "Blank");
            }
            //inv[0] = slot1
            //re.Ask(inv[0].foodString);


            JobUpgrade bst1 = new JobUpgrade(0, 1, "Bad Stick", "It's a stick, what did you expect?", false);
            JobUpgrade sh1 = new JobUpgrade(50, 2, "Sharp Stick", "Just a slightly sharpened stick", false);
            JobUpgrade wo1 = new JobUpgrade(200, 3, "Wooden Sword", "Just a sharp stick shaped like a sword", false);
            JobUpgrade st1 = new JobUpgrade(500, 4, "Stone Sword", "Used for cutting thicker grass", false);
            JobUpgrade fw1 = new JobUpgrade(9^9, 4, "Sold Out", "Currently there are no more upgrades available", true);

            //v1 price, v2 jobupgrade, v3jobupgradename, v4 jobupgrade description



            // Assigns the value of v1 price v2 quantity v3 health gain, v4 hunger, v5 string
            JobUpgrade[] jobUpgradeArray = new JobUpgrade[] {bst1, sh1, wo1, st1, fw1};
            pl.hunger = pl.startHunger;
            pl.health = pl.startHealth;
            while(gameOn == true)
            {
                // 1 2 or 3 for each case
                JFood pz1 = new JFood(3, 8, 0, 2, ($"Pizza Slice"));
                JFood dt1 = new JFood(2, 12, 0, 1, ("Donut"));
                JFood bs1 = new JFood(6, 2, 1, 6, ("BLT Sammy"));
                // Banana Apple Orange
                HFood ba1 = new HFood(10, 3, 1, 3, ("Banana"));
                HFood ap1 = new HFood(10, 1, 3, 1, ("Apple"));
                HFood or1 = new HFood(8, 1, 2, 2, ("Orange"));
                // OctoPopRocs, SugarSkullTulas, DekuPeanuts
                MFood oc1 = new MFood(4, 10, -1, 1, ("OctoPopRocs"));
                MFood su1 = new MFood(5, 5, -1, 0, ("SugarSkullTulas"));
                MFood de1 = new MFood(9, 3, -2, 3, ("DekuPeanuts"));
                JFood[] jfoodArray = new JFood[3] { pz1, dt1, bs1 };
                HFood[] hfoodArray = new HFood[3] { ba1, ap1, or1 };
                MFood[] mfoodArray = new MFood[3] { oc1, su1, de1 };
                jfoodRandomizer = rd.Next(0, 3);
                hfoodRandomizer = rd.Next(0, 3);
                mfoodRandomizer = rd.Next(0, 3);
                while (goHome == false)
                {
                    goBack = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string buysellrentask = re.Ask("Welcome to my shop mighty traveler \r\n\r\nWould you like to Buy[1], Sell[2], Rent[3]?, Check inventory[i]? go Home[g]? or quit [q] >");
                    buysellrentask = buysellrentask.ToLower();
                    int buysellrent = 0;
                    Int32.TryParse(buysellrentask, out buysellrent);
                    switch (buysellrentask)
                    {
                        case "i":
                            while (goBack == true)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Which item would you like to select between 0-8? Or type [b] to go back >\r\n");
                                for (int i = 0; i < 9; i++)
                                {
                                    Console.WriteLine($"\r\nItem Slot {i}");
                                    Console.WriteLine($"Item : {inv[i].foodString}\r\nHealth Gain : {inv[i].healthGain}\r\nHunger Gain : {inv[i].hungerGain}");
                                }
                                useAsk = Console.ReadLine();
                                useAsk = useAsk.ToLower();
                                if (useAsk == "b" || useAsk == "b")
                                {
                                    goBack = false;
                                    goHome = false;
                                    break;
                                }
                                Int32.TryParse(useAsk, out use);
                                

                                for (int i = 0; i < 8; i++)
                                {
                                    inv[use] = inv[use + 1];
                                    use++;
                                }
                                slotChecker--;
                                goHome = false;
                                break;
                                //delete inv[use]

                                //

                                //switch (use)
                                //{
                                //    case 1:

                                //        break;

                                //default:
                                //        goBack = false;
                                //Console.WriteLine("Incorrect input, press any key to continue >");
                                //Console.ReadKey();
                                //break;
                                
                            }
                            continue;

                        case "g":

                            goHome = true;
                            break;

                        case "q":
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
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("Here is what I have available for today!\r\n");
                                        Console.WriteLine($"{jfoodArray[jfoodRandomizer].foodString}[1]\r\n{hfoodArray[hfoodRandomizer].foodString}[2]\r\n{mfoodArray[mfoodRandomizer].foodString}[3]\r\n{jobUpgradeArray[currentWeapon+1].jobUpgradeName}[4]\r\nor back to store front[b]\r\n");
                                        string foodAsk = re.Ask("What would you like to do? >");
                                        foodAsk = foodAsk.ToLower();
                                        if (foodAsk == "b" || foodAsk == "b")
                                        {
                                            goBack = false;
                                            break;
                                        }
                                        int foodSure = 0;
                                        Int32.TryParse(foodAsk, out foodSure);

                                        switch (foodSure)
                                        {   //Junk Food 
                                            case 1:
                                                //Note to self make void and when calling it here fill the parameter with j h or m
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                purchaseAsk = re.Ask($"You have selected the {jfoodArray[jfoodRandomizer].foodString}\r\n\r\n{jfoodArray[jfoodRandomizer].foodString}\r\n" +
                                                $"Price : {jfoodArray[jfoodRandomizer].price} \r\n" +
                                                $"Quantity : {jfoodArray[jfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : {jfoodArray[jfoodRandomizer].healthGain} \r\n" +
                                                $"Hunger Gain : {jfoodArray[jfoodRandomizer].hungerGain}\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();


                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((jfoodArray[jfoodRandomizer].quantity > 0) && (pl.rupees >= jfoodArray[jfoodRandomizer].price)))
                                                {
                                                    invSort.JInventorySorter(inv, slotChecker, jfoodArray, jfoodRandomizer);
                                                    if (invSort.runInvSort == true)
                                                    {
                                                        jfoodArray[jfoodRandomizer].quantity -= 1;
                                                        pl.rupees -= jfoodArray[jfoodRandomizer].price;
                                                        slotChecker++;
                                                        break;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((jfoodArray[jfoodRandomizer].quantity > 0) && (pl.rupees >= jfoodArray[jfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine($"You have selected the {jfoodArray[jfoodRandomizer].foodString}\r\n\r\n{jfoodArray[jfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {jfoodArray[jfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {jfoodArray[jfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : ?\r\n" +
                                                    $"Hunger Gain : ?\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress and key to go back >");
                                                    Console.ReadKey();
                                                }
                                                break;


                                            //Healthy Food
                                            case 2:
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                purchaseAsk = re.Ask($"You have selected the {hfoodArray[hfoodRandomizer].foodString}\r\n\r\n{hfoodArray[hfoodRandomizer].foodString}\r\n" +
                                                $"Price : {hfoodArray[hfoodRandomizer].price} \r\n" +
                                                $"Quantity : {hfoodArray[hfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : {hfoodArray[hfoodRandomizer].healthGain} \r\n" +
                                                $"Hunger Gain : {hfoodArray[hfoodRandomizer].hungerGain}\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();

                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((hfoodArray[hfoodRandomizer].quantity > 0) && (pl.rupees >= hfoodArray[hfoodRandomizer].price)))
                                                {
                                                    invSort.HInventorySorter(inv, slotChecker, hfoodArray, hfoodRandomizer);
                                                    if (invSort.runInvSort == true)
                                                    {
                                                        hfoodArray[hfoodRandomizer].quantity -= 1;
                                                        pl.rupees -= hfoodArray[hfoodRandomizer].price;
                                                        slotChecker++;
                                                        break;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((hfoodArray[hfoodRandomizer].quantity > 0) && (pl.rupees >= hfoodArray[hfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine($"You have selected the {hfoodArray[hfoodRandomizer].foodString}\r\n\r\n{hfoodArray[hfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {hfoodArray[hfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {hfoodArray[hfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : ?\r\n" +
                                                    $"Hunger Gain : ?\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress and key to go back >");
                                                    Console.ReadKey();
                                                }

                                                break;
                                            //Mystery food
                                            case 3:
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                purchaseAsk = re.Ask($"You have selected the {mfoodArray[mfoodRandomizer].foodString}\r\n\r\n{mfoodArray[mfoodRandomizer].foodString}\r\n" +
                                                $"Price : {mfoodArray[mfoodRandomizer].price} \r\n" +
                                                $"Quantity : {mfoodArray[mfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : ?\r\n" +
                                                $"Hunger Gain : ?\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();

                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((mfoodArray[mfoodRandomizer].quantity > 0) && (pl.rupees >= mfoodArray[mfoodRandomizer].price)))
                                                {
                                                    invSort.MInventorySorter(inv, slotChecker, mfoodArray, mfoodRandomizer);
                                                    if (invSort.runInvSort == true)
                                                    {
                                                        mfoodArray[mfoodRandomizer].quantity -= 1;
                                                        pl.rupees -= mfoodArray[mfoodRandomizer].price;
                                                        slotChecker++;
                                                        break;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((mfoodArray[mfoodRandomizer].quantity > 0) && (pl.rupees >= mfoodArray[mfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine($"You have selected the {mfoodArray[mfoodRandomizer].foodString}\r\n\r\n{mfoodArray[mfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {mfoodArray[mfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {mfoodArray[mfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : ?\r\n" +
                                                    $"Hunger Gain : ?\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress and key to go back >");
                                                    Console.ReadKey();
                                                }
                                                    break;

                                                //Next available weapon
                                            case 4:
                                                Console.Clear();
                                                if (jobUpgradeArray[currentWeapon+1].finalWeapon == false)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    purchaseAsk = re.Ask($"You have selected the {jobUpgradeArray[currentWeapon+1].jobUpgradeName}\r\n\r\n{jobUpgradeArray[currentWeapon+1].jobUpgradeName}\r\n" +
                                                    $"Price : {jobUpgradeArray[currentWeapon+1].price} \r\n" +
                                                    $"Preformance : {jobUpgradeArray[currentWeapon+1].jobUpgrade} \r\n" +
                                                    $"Description : {jobUpgradeArray[currentWeapon+1].upgradeDescription}\r\n\r\n" +
                                                    $"Are you sure you would like to purchase this? [y] [n]? >");
                                                    purchaseAsk = purchaseAsk.ToLower();

                                                    if (((purchaseAsk == "y") || (purchaseAsk == "yes")) && (pl.rupees >= jobUpgradeArray[currentWeapon+1].price))
                                                    {
                                                        pl.rupees -= jobUpgradeArray[currentWeapon+1].price;
                                                        currentWeapon += 1;
                                                        //mfoodArray[foodRandomizer1].quantity -= 1;
                                                        //pl.rupees -= mfoodArray[foodRandomizer1].price;
                                                    }
                                                    else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !(pl.rupees >= jobUpgradeArray[currentWeapon+1].price))
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                        Console.WriteLine($"You have selected the {jobUpgradeArray[currentWeapon + 1].jobUpgradeName}\r\n\r\n{jobUpgradeArray[currentWeapon + 1].jobUpgradeName}\r\n" +
                                                        $"Price : {jobUpgradeArray[currentWeapon + 1].price} \r\n" +
                                                        $"Preformance : {jobUpgradeArray[currentWeapon + 1].jobUpgrade} \r\n" +
                                                        $"Description : {jobUpgradeArray[currentWeapon + 1].upgradeDescription}\r\n\r\n" +
                                                        $"You can't afford this\r\nPress and key to go back >");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    purchaseAsk = re.Ask($"{jobUpgradeArray[currentWeapon + 1].jobUpgradeName}\r\n" +
                                                    $"Description : {jobUpgradeArray[currentWeapon + 1].upgradeDescription}\r\n\r\n" +
                                                    $"Press and key to go back >");
                                                }

                                                break;

                                        }
                                        break;

                                    //Case for selling
                                    case 2:
                                        goBack = false;
                                        Console.WriteLine("Work in progress, press any key to continue >");
                                        Console.ReadKey();

                                        break;
                                    //Case for renting
                                    case 3:
                                        goBack = false;
                                        Console.WriteLine("work in progress, press any key to continue >");
                                        Console.ReadKey();
                                        break;

                                    default:
                                        goBack = false;
                                        Console.WriteLine("Incorrect input, press any key to continue >");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            continue;
                    }
                    break;
                }
                Console.Clear();
                if (gameOn == false)
                {
                    Console.Clear();
                    Console.WriteLine("Saving...\r\nNow Exiting.");
                    break;
                }
                goalDay = 0;
                multiplierRupee = 0;
                goalDayAsked = "";
                goalDayAsked += re.Ask($"How many days would you like to sleep and work before returning to the shop");
                Int32.TryParse(goalDayAsked, out goalDay);
                for (int i = 0; i < goalDay; i++)
                {
                    pl.hunger -= rd.Next(0, 3);
                    if (pl.health <= 0)
                    {
                        break;
                    }
                    if (pl.hunger < 1)
                    {
                        pl.hunger = 0;
                        pl.health -= (rd.Next(1,3));
                    }

                    multiplierRupee = (rd.Next(3, 7) * jobUpgradeArray[currentWeapon].jobUpgrade);
                    pl.rupees += multiplierRupee;
                    foundRupees += multiplierRupee;
                    currentDay++;
                }

                if (pl.health <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You starved to death, nice job");
                    gameOn = false;
                    Console.ReadKey();
                    break;

                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Day : {currentDay}\r\nRupees : {pl.rupees}\r\nHealth : {pl.health}\r\nHunger : {pl.hunger}\r\n---------------\r\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"You work and sleep for {goalDay} days\r\nWith your {jobUpgradeArray[currentWeapon].jobUpgradeName} you mananged to get {foundRupees} Rupees\r\n\r\nPress Any Key To Continue >");
                multiplierRupee = 0;
                foundRupees = 0;
                goHome = false;
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
