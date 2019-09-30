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
            //method to write and readline. 
            public string Ask(string _val)
            {
                Console.WriteLine(_val);

                return Console.ReadLine();
            }
        }
        class TryCatch
        // Try catches for an out of bounds error (The player tried purchasing an item when then had no space) and sorts the purchased item values into the determined spot in your inventorty.
        {
            public bool runInvSort =  true;
            public void JInventorySorter(Inventory[] v1, int v2,JFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer.
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    v1[v2].slotFilled = v3[v4].slotFilled;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();

                }
                return;
            }

            public void HInventorySorter(Inventory[] v1, int v2, HFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer.
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    v1[v2].slotFilled = v3[v4].slotFilled;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();
                }
                return;
            }

            public void MInventorySorter(Inventory[] v1, int v2, MFood[] v3, int v4)
            { // v1 inv v2 slotchecker v3 jfoodarray v4 jfood randomizer.
                try
                {
                    v1[v2].price = v3[v4].price;
                    v1[v2].healthGain = v3[v4].healthGain;
                    v1[v2].hungerGain = v3[v4].hungerGain;
                    v1[v2].foodString = v3[v4].foodString;
                    v1[v2].slotFilled = v3[v4].slotFilled;
                    runInvSort = true;
                }
                catch (System.IndexOutOfRangeException)
                {
                    runInvSort = false;
                    Console.WriteLine("You're inventory is full! You can't do that!");
                    Console.ReadKey();
                }
                return;
            }
        }


        static void Main(string[] args)
        {
            TryCatch invSort = new TryCatch();
            Player pl = new Player();
            Random rd = new Random();
            Read re = new Read();
            Pet[] petArray = new Pet[6];
            Inventory[] inv = new Inventory[9];
            petArray[0] = new Wolf(1, 1, "Grey Wolf");
            petArray[1] = new Wolf(2, 3, "Winter Wolf");
            petArray[2] = new Wolf(3, 4, "Golden Wolf");
            petArray[3] = new Fox(1, 1, "Grey Fox");
            petArray[4] = new Fox(2, 3, "Orange Fox");
            petArray[5] = new Fox(3, 4, "Platinum Fox");
            //All of the item/job upgrades you can buy in the shop to progress faster
            JobUpgrade bst1 = new JobUpgrade(0, 1, "Bad Stick", "It's a stick, what did you expect?", false);
            JobUpgrade sh1 = new JobUpgrade(50, 2, "Sharp Stick", "Just a slightly sharpened stick", false);
            JobUpgrade wo1 = new JobUpgrade(100, 3, "Wooden Sword", "Just a sharp stick shaped like a sword", false);
            JobUpgrade st1 = new JobUpgrade(250, 4, "Stone Sword", "Used for cutting thicker grass", false);
            JobUpgrade cc1 = new JobUpgrade(500, 6, "Cociri Sword", "The treasure of cociri", false);
            JobUpgrade gk1 = new JobUpgrade(750, 8, "Giant's Knife", "Weilding this sword makes you feel six years older..hmmm", false);
            JobUpgrade bg1 = new JobUpgrade(1000, 10, "Biggy's Sword", "From Garan City, this weapon is twice as strong as the NotMaster Sword", false);
            JobUpgrade ms1 = new JobUpgrade(2000, 15, "NotMaster Sword", "Literally smaller and weaker than Biggy's sword, but it's cool so you can swing it faster", false);
            JobUpgrade lm1 = new JobUpgrade(2500, 100, "Hylian LawnMower", "I mean it sounds like a dangerous idea to run over gems and rocks with a lawnmower, but you do you...", false);
            JobUpgrade fw1 = new JobUpgrade(9^9, 4, "Sold Out", "Currently there are no more upgrades available", true);
            //v1 price, v2 jobupgrade, v3jobupgradename, v4 jobupgrade description.
            JobUpgrade[] jobUpgradeArray = new JobUpgrade[] {bst1, sh1, wo1, st1, cc1, gk1, bg1, ms1, lm1, fw1};

            //Where most of the games initalization takes place
            int slotChecker = 0;
            int jfoodRandomizer = 0;
            int hfoodRandomizer = 0;
            int mfoodRandomizer = 0;
            int petRandomizer = 0;
            int currentWeapon = 0;
            int goalDay = 0;
            int currentDay = 1;
            int multiplierRupee = 0;
            int foundRupees = 0; 
            int use = 0;
            string saveAsk = "";
            string goalDayAsked = "";
            string purchaseAsk = "";
            string useAsk = "";
            bool slotFound = false; 
            bool goHome = false;
            bool goBack = true;
            bool gameOn = true;
            bool startGame = false;
            string[] invValue = new string[9] { "inv1.txt", "inv2.txt", "inv3.txt", "inv4.txt", "inv5.txt", "inv6.txt", "inv7.txt", "inv8.txt", "inv9.txt" };
            pl.hunger = pl.startHunger;
            pl.health = pl.startHealth;
            //Fills the inventory array with blanks spots so they can be overwritten with new values.            
            for (int i = 0; i < 9; i++)
            {
                inv[i] = new Inventory(0, 0, 0, "Blank", false);
            }
            //A void for my UI call, so I don't have to reprint the money/days/health etc of the player over and over.
            void UI()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Day : {currentDay}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rupees : {pl.rupees}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Health : {pl.health}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"Hunger : {pl.hunger}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\r\n---------------\r\n");
                return;
            }

            //Beginning of my game, asks if the player would like to load or start a new game, if they load it looks into previously
            //stored text files and sets the rupees, health, items etc to values of the save files. But if the player selects new it
            //initalizes new variables and arrays for everything.
            saveAsk = re.Ask($"Welcome to my game, RPG Grass Cutting Store Game!\r\nType [load] to load the previous game\r\nType [new] to start a new game and overwrite the save");
            saveAsk = saveAsk.ToLower();

            
            while (gameOn == true)
            {
                while (startGame == false)
                {
                    switch (saveAsk)
                    {
                        case "load":
                            StreamReader readerRupees = new StreamReader("pl.rupees.txt");
                            string RupeesSave = readerRupees.ReadLine();
                            Int32.TryParse(RupeesSave, out pl.rupees);
                            readerRupees.Close();
                            StreamReader readerHealth = new StreamReader("pl.health.txt");
                            string HealthSave = readerHealth.ReadLine();
                            Int32.TryParse(HealthSave, out pl.health);
                            readerHealth.Close();
                            StreamReader readerHunger = new StreamReader("pl.hunger.txt");
                            string HungerSave = readerHunger.ReadLine();
                            Int32.TryParse(HungerSave, out pl.hunger);
                            readerHunger.Close();
                            StreamReader readerCurrentWeapon = new StreamReader("currentWeapon.txt");
                            string CurrentWeaponSave = readerCurrentWeapon.ReadLine();
                            Int32.TryParse(CurrentWeaponSave, out currentWeapon);
                            readerCurrentWeapon.Close();
                            StreamReader readerSlotChecker = new StreamReader("slotChecker.txt");
                            string slotCheckerSave = readerSlotChecker.ReadLine();
                            Int32.TryParse(slotCheckerSave, out slotChecker);
                            readerSlotChecker.Close();
                            StreamReader readerCurrentDay = new StreamReader("currentDay.txt");
                            string currentDaySave = readerCurrentDay.ReadLine();
                            Int32.TryParse(currentDaySave, out currentDay);
                            readerCurrentDay.Close();

                            
                            
                            StreamReader readerInv1 = new StreamReader("../../TextFiles/inv1.txt");
                            inv[0].foodString = readerInv1.ReadLine();
                            string invHealth1Save = readerInv1.ReadLine();
                            Int32.TryParse(invHealth1Save, out inv[0].healthGain);
                            string invHunger1Save = readerInv1.ReadLine();
                            Int32.TryParse(invHunger1Save, out inv[0].hungerGain);
                            readerInv1.Close();

                            StreamReader readerInv2 = new StreamReader("../../TextFiles/inv2.txt");
                            inv[1].foodString = readerInv2.ReadLine();
                            string invHealth2Save = readerInv2.ReadLine();
                            Int32.TryParse(invHealth2Save, out inv[1].healthGain);
                            string invHunger2Save = readerInv2.ReadLine();
                            Int32.TryParse(invHunger2Save, out inv[1].hungerGain);
                            readerInv2.Close();

                            StreamReader readerInv3 = new StreamReader("../../TextFiles/inv3.txt");
                            inv[2].foodString = readerInv3.ReadLine();
                            string invHealth3Save = readerInv3.ReadLine();
                            Int32.TryParse(invHealth3Save, out inv[2].healthGain);
                            string invHunger3Save = readerInv3.ReadLine();
                            Int32.TryParse(invHunger3Save, out inv[2].hungerGain);
                            readerInv3.Close();

                            StreamReader readerInv4 = new StreamReader("../../TextFiles/inv4.txt");
                            inv[3].foodString = readerInv4.ReadLine();
                            string invHealth4Save = readerInv4.ReadLine();
                            Int32.TryParse(invHealth4Save, out inv[3].healthGain);
                            string invHunger4Save = readerInv4.ReadLine();
                            Int32.TryParse(invHunger4Save, out inv[3].hungerGain);
                            readerInv4.Close();

                            StreamReader readerInv5 = new StreamReader("../../TextFiles/inv5.txt");
                            inv[4].foodString = readerInv5.ReadLine();
                            string invHealth5Save = readerInv5.ReadLine();
                            Int32.TryParse(invHealth5Save, out inv[4].healthGain);
                            string invHunger5Save = readerInv5.ReadLine();
                            Int32.TryParse(invHunger5Save, out inv[4].hungerGain);
                            readerInv5.Close();

                            StreamReader readerInv6 = new StreamReader("../../TextFiles/inv6.txt");
                            inv[5].foodString = readerInv6.ReadLine();
                            string invHealth6Save = readerInv6.ReadLine();
                            Int32.TryParse(invHealth6Save, out inv[5].healthGain);
                            string invHunger6Save = readerInv6.ReadLine();
                            Int32.TryParse(invHunger6Save, out inv[5].hungerGain);
                            readerInv6.Close();

                            StreamReader readerInv7 = new StreamReader("../../TextFiles/inv7.txt");
                            inv[6].foodString = readerInv7.ReadLine();
                            string invHealth7Save = readerInv7.ReadLine();
                            Int32.TryParse(invHealth7Save, out inv[6].healthGain);
                            string invHunger7Save = readerInv7.ReadLine();
                            Int32.TryParse(invHunger7Save, out inv[6].hungerGain);
                            readerInv7.Close();


                            StreamReader readerInv8 = new StreamReader("../../TextFiles/inv8.txt");
                            inv[7].foodString = readerInv8.ReadLine();
                            string invHealth8Save = readerInv8.ReadLine();
                            Int32.TryParse(invHealth8Save, out inv[7].healthGain);
                            string invHunger8Save = readerInv8.ReadLine();
                            Int32.TryParse(invHunger8Save, out inv[7].hungerGain);
                            readerInv8.Close();

                            StreamReader readerInv9 = new StreamReader("../../TextFiles/inv9.txt");
                            inv[8].foodString = readerInv9.ReadLine();
                            string invHealth9Save = readerInv9.ReadLine();
                            Int32.TryParse(invHealth9Save, out inv[8].healthGain);
                            string invHunger9Save = readerInv9.ReadLine();
                            Int32.TryParse(invHunger9Save, out inv[8].hungerGain);
                            readerInv9.Close();

                            Console.Clear();
                            Console.WriteLine("Loading....\r\nDone, Press any key to continue >");
                            Console.ReadKey();
                            startGame = true;
                            break;

                        case "new":
                            petRandomizer = rd.Next(0, 7);
                            Console.Clear();
                            Console.WriteLine("After turning 11, like every video game adventurer, you finally decided it was time to move out and adventure.\r\n" +
                                "You decide Cacirco Village would be a nice place to live, but you need 50,000 rupees to afford a new house there. \r\nPress any key to continue >");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine($"You walk out into Cocori Forest and find a nearby stick and begin cutting grass, finding a whole 10 rupees! As well as a new pet {petArray[petRandomizer].PType}" +
                                "\r\nYou decide to go to the local shop and see what they have available. \r\nPress any key to continue >");
                            Console.ReadKey();

                            pl.rupees = 10;
                            pl.health = pl.startHealth;
                            pl.hunger = pl.startHunger;
                            currentWeapon = 0;
                            slotChecker = 0;
                            currentDay = 1;
                            startGame = true;
                            break;

                        default:
                            saveAsk = re.Ask("Wrong input, please pick load or new");
                            
                            
                            break;
                    }
                }
                //These are my classes "Junk food, Healthy Food, and Mystery Food" all being made and sorted
                //into an array so the shopkeeper's inventory is different each day.
                // 1 2 or 3 for each case
                JFood pz1 = new JFood(3, 8, 0, 2, ($"Pizza Slice"), true);
                JFood dt1 = new JFood(2, 12, 0, 1, ("Donut"), true);
                JFood bs1 = new JFood(6, 2, 1, 6, ("BLT Sammy"), true);
                // Banana Apple Orange
                HFood ba1 = new HFood(10, 3, 1, 3, ("Banana"), true);
                HFood ap1 = new HFood(10, 1, 3, 1, ("Apple"), true);
                HFood or1 = new HFood(8, 1, 2, 2, ("Orange"), true);
                // OctoPopRocs, SugarSkullTulas, DekuPeanuts
                MFood oc1 = new MFood(4, 10, -1, 1, ("OctoPopRocs"), true);
                MFood su1 = new MFood(5, 5, -1, 0, ("SugarSkullTulas"), true);
                MFood de1 = new MFood(9, 3, -2, 3, ("DekuPeanuts"), true);
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
                    UI();
                    string buysellask = re.Ask("Welcome to my shop mighty traveler \r\n\r\nWould you like to Buy[1], Sell[2], Check [i]nventory, [g]o Home, [p]et your animal? or [q]uit and save? >");
                    buysellask = buysellask.ToLower();
                    int buysell = 0;
                    Int32.TryParse(buysellask, out buysell);
                    switch (buysellask)
                    {   //Allows player to see their inventory array and prints it's values to the console.
                        case "i":
                            while (goBack == true)
                            {
                                 
                                Console.Clear();
                                UI();
                                Console.WriteLine("Which item would you like to select between 1-9? Or type [b] to go back >\r\n");
                                for (int i = 0; i < 9; i++)
                                {
                                    Console.WriteLine($"\r\nItem Slot {i+1}");
                                    Console.WriteLine($"Item : {inv[i].foodString}");
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
                                // if there is an item, ask the player if they want to use it.
                                if ((use < 10 && use > 0) && (inv[use-1].slotFilled == true))
                                {
                                    use -= 1;
                                    Console.Clear();
                                    UI();
                                    useAsk = re.Ask($"You have selected Item : {inv[use].foodString}\r\nHealth Gain : {inv[use].healthGain}\r\nHunger Gain : {inv[use].hungerGain}\r\n\r\nWould you like to use this? [y]es or [n]o >");
                                    useAsk = useAsk.ToLower();
                                    if (useAsk == "y" || useAsk == "yes")
                                    {
                                        //If the player decides to eat the item, it deletes it from the inventory and reduces the currently selected slot
                                        //and then adjusts the players health and hunger
                                        Console.WriteLine($"You eat the {inv[use].foodString}");
                                        Console.ReadKey();
                                        pl.health += inv[use].healthGain;
                                        pl.hunger += inv[use].hungerGain;
                                        if (pl.hunger > pl.startHunger)
                                        {
                                            pl.hunger = pl.startHunger;
                                        }
                                        if (pl.health > pl.startHealth)
                                        {
                                            pl.health = pl.startHealth;
                                        }
                                        for (int i = use; i < 8; i++)
                                        {
                                            inv[i] = inv[i + 1];
                                        }
                                        inv[8] = new Inventory(0, 0, 0, "Blank", false);
                                        slotFound = true;

                                        slotChecker--;
                                        if (slotChecker < 0)
                                        {
                                            slotChecker = 0;
                                        }

                                    }
                                    goBack = true;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect input");
                                    Console.ReadKey();
                                }
                                
                                
                            }
                            continue;
                            //pulls the player out of the loop, to go home and make money
                        case "g":

                            goHome = true;
                            break;
                            //breaks out of the main gameplay loop and saves the game
                        case "q":
                            gameOn = false;
                            break;

                        case "p":

                            break;

                        default:
                            while (goBack == true)
                            {   // Checks if the player wants to buy or sell.
                                switch (buysell)
                                {
                                    //Case for buying
                                    case 1:
                                        Console.Clear();
                                        UI();
                                        Console.WriteLine("Here is what I have available for today!\r\n");
                                        Console.WriteLine($"{jfoodArray[jfoodRandomizer].foodString}[1]\r\n{hfoodArray[hfoodRandomizer].foodString}[2]\r\n{mfoodArray[mfoodRandomizer].foodString}[3]\r\n{jobUpgradeArray[currentWeapon+1].jobUpgradeName}[4]\r\nor back to store front[b]\r\n");
                                        string foodAsk = re.Ask("What would you like to do? >");
                                        foodAsk = foodAsk.ToLower();
                                        if (foodAsk == "b" )
                                        {
                                            goBack = false;
                                            break;
                                        }
                                        int foodSure = 0;
                                        Int32.TryParse(foodAsk, out foodSure);

                                        switch (foodSure)
                                        {   //Junk Food 
                                            case 1:
                                                //Shows the player the selected food and it's values, and then double checks if the player would like to purchase it
                                                Console.Clear();
                                                UI();
                                                purchaseAsk = re.Ask($"You have selected the {jfoodArray[jfoodRandomizer].foodString}\r\n\r\n{jfoodArray[jfoodRandomizer].foodString}\r\n" +
                                                $"Price : {jfoodArray[jfoodRandomizer].price} \r\n" +
                                                $"Quantity : {jfoodArray[jfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : {jfoodArray[jfoodRandomizer].healthGain} \r\n" +
                                                $"Hunger Gain : {jfoodArray[jfoodRandomizer].hungerGain}\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();

                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((jfoodArray[jfoodRandomizer].quantity > 0) && (pl.rupees >= jfoodArray[jfoodRandomizer].price)))
                                                {   //This double checks that there are spaces available to place a new item and determines the next spot to place it in your inventory.
                                                    slotFound = false;
                                                    while(slotFound == false)
                                                    {
                                                        if (slotChecker > 8)
                                                        {
                                                            Console.WriteLine("You can't do that your inventory is full!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (inv[slotChecker].slotFilled == false)
                                                        {
                                                            invSort.JInventorySorter(inv, slotChecker, jfoodArray, jfoodRandomizer);
                                                            if (invSort.runInvSort == true)
                                                            {
                                                                jfoodArray[jfoodRandomizer].quantity -= 1;
                                                                pl.rupees -= jfoodArray[jfoodRandomizer].price;
                                                                slotChecker++;
                                                                //I honestly think it's annoying you have to hit another button here, but I had to add it
                                                                //if the player purchases items too fast, the array bugs out and assigns everything to the same item
                                                                Console.WriteLine("You stow the item into your inventory");
                                                                Console.ReadKey();
                                                                slotFound = true;
                                                                break;
                                                            }
                                                        }

                                                        slotChecker++;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((jfoodArray[jfoodRandomizer].quantity > 0) && (pl.rupees >= jfoodArray[jfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    UI();
                                                    Console.WriteLine($"You have selected the {jfoodArray[jfoodRandomizer].foodString}\r\n\r\n{jfoodArray[jfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {jfoodArray[jfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {jfoodArray[jfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : {jfoodArray[jfoodRandomizer].healthGain}\r\n" +
                                                    $"Hunger Gain : {jfoodArray[jfoodRandomizer].hungerGain}\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress any key to go back >");
                                                    Console.ReadKey();
                                                }
                                                break;


                                            //Healthy Food
                                            case 2:
                                                Console.Clear();
                                                UI();
                                                purchaseAsk = re.Ask($"You have selected the {hfoodArray[hfoodRandomizer].foodString}\r\n\r\n{hfoodArray[hfoodRandomizer].foodString}\r\n" +
                                                $"Price : {hfoodArray[hfoodRandomizer].price} \r\n" +
                                                $"Quantity : {hfoodArray[hfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : {hfoodArray[hfoodRandomizer].healthGain} \r\n" +
                                                $"Hunger Gain : {hfoodArray[hfoodRandomizer].hungerGain}\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();

                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((hfoodArray[hfoodRandomizer].quantity > 0) && (pl.rupees >= hfoodArray[hfoodRandomizer].price)))
                                                {
                                                    slotFound = false;
                                                    while (slotFound == false)
                                                    {
                                                        if (slotChecker > 8)
                                                        {
                                                            Console.WriteLine("You can't do that your inventory is full!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (inv[slotChecker].slotFilled == false)
                                                        {
                                                            invSort.HInventorySorter(inv, slotChecker, hfoodArray, hfoodRandomizer);
                                                            if (invSort.runInvSort == true)
                                                            {
                                                                hfoodArray[hfoodRandomizer].quantity -= 1;
                                                                pl.rupees -= hfoodArray[hfoodRandomizer].price;
                                                                slotChecker++;
                                                                //I honestly think it's annoying you have to hit another button here, but I had to add it
                                                                //if the player purchases items too fast, the array bugs out and assigns everything to the same item
                                                                Console.WriteLine("You stow the item into your inventory");
                                                                Console.ReadKey();
                                                                slotFound = true;
                                                                break;
                                                            }
                                                        }

                                                        slotChecker++;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((hfoodArray[hfoodRandomizer].quantity > 0) && (pl.rupees >= hfoodArray[hfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    UI();
                                                    Console.WriteLine($"You have selected the {hfoodArray[hfoodRandomizer].foodString}\r\n\r\n{hfoodArray[hfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {hfoodArray[hfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {hfoodArray[hfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : {hfoodArray[hfoodRandomizer].healthGain}\r\n" +
                                                    $"Hunger Gain : {hfoodArray[hfoodRandomizer].hungerGain}\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress any key to go back >");
                                                    Console.ReadKey();
                                                }
                                                break;
                                            //Mystery food
                                            case 3:
                                                Console.Clear();
                                                UI();
                                                purchaseAsk = re.Ask($"You have selected the {mfoodArray[mfoodRandomizer].foodString}\r\n\r\n{mfoodArray[mfoodRandomizer].foodString}\r\n" +
                                                $"Price : {mfoodArray[mfoodRandomizer].price} \r\n" +
                                                $"Quantity : {mfoodArray[mfoodRandomizer].quantity} \r\n" +
                                                $"Health Gain : ?\r\n" +
                                                $"Hunger Gain : ?\r\n\r\n" +
                                                $"Are you sure you would like to purchase this? [y] [n]? >");
                                                purchaseAsk = purchaseAsk.ToLower();


                                                if (((purchaseAsk == "y" || purchaseAsk == "yes")) && ((mfoodArray[mfoodRandomizer].quantity > 0) && (pl.rupees >= mfoodArray[mfoodRandomizer].price)))
                                                {
                                                    slotFound = false;
                                                    while (slotFound == false)
                                                    {
                                                        if (slotChecker > 8)
                                                        {
                                                            Console.WriteLine("You can't do that your inventory is full!");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (inv[slotChecker].slotFilled == false)
                                                        {
                                                            invSort.MInventorySorter(inv, slotChecker, mfoodArray, mfoodRandomizer);
                                                            if (invSort.runInvSort == true)
                                                            {
                                                                mfoodArray[mfoodRandomizer].quantity -= 1;
                                                                pl.rupees -= mfoodArray[mfoodRandomizer].price;
                                                                slotChecker++;
                                                                //I honestly think it's annoying you have to hit another button here, but I had to add it
                                                                //if the player purchases items too fast, the array bugs out and assigns everything to the same item
                                                                Console.WriteLine("You stow the item into your inventory");
                                                                Console.ReadKey();
                                                                slotFound = true;
                                                                break;
                                                            }
                                                        }

                                                        slotChecker++;
                                                    }
                                                    Console.WriteLine($"Rupees = {pl.rupees}\r\nHunger : {pl.hunger}");
                                                }
                                                else if (((purchaseAsk == "y" || purchaseAsk == "yes")) && !((mfoodArray[mfoodRandomizer].quantity > 0) && (pl.rupees >= mfoodArray[mfoodRandomizer].price)))
                                                {
                                                    Console.Clear();
                                                    UI();
                                                    Console.WriteLine($"You have selected the {mfoodArray[mfoodRandomizer].foodString}\r\n\r\n{mfoodArray[mfoodRandomizer].foodString}\r\n" +
                                                    $"Price : {mfoodArray[mfoodRandomizer].price} \r\n" +
                                                    $"Quantity : {mfoodArray[mfoodRandomizer].quantity} \r\n" +
                                                    $"Health Gain : {mfoodArray[mfoodRandomizer].healthGain}\r\n" +
                                                    $"Hunger Gain : {mfoodArray[mfoodRandomizer].hungerGain}\r\n\r\nEither you can't afford this, or there are none left in stock\r\nPress any key to go back >");
                                                    Console.ReadKey();
                                                }
                                                break;

                                            //Next available weapon
                                            case 4:
                                                Console.Clear();
                                                if (jobUpgradeArray[currentWeapon+1].finalWeapon == false)
                                                {
                                                    UI();
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
                                                        UI();
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
                                                    UI();
                                                    purchaseAsk = re.Ask($"{jobUpgradeArray[currentWeapon + 1].jobUpgradeName}\r\n" +
                                                    $"Description : {jobUpgradeArray[currentWeapon + 1].upgradeDescription}\r\n\r\n" +
                                                    $"Press and key to go back >");
                                                }

                                                break;

                                        }
                                        break;

                                    //Case for selling
                                    //Extremely similar to how the "use" process works in the inventory case, when confirming to sell
                                    //the game deletes the item from your inventory and gives you around half the rupees back that you spent on it.
                                    case 2:
                                        Console.Clear();
                                        UI();
                                        Console.WriteLine("What Items would you like to sell? press [b] to go back >");
                                        for (int i = 0; i < 9; i++)
                                        {
                                            Console.WriteLine($"\r\nItem Slot {i + 1}");
                                            Console.WriteLine($"Item : {inv[i].foodString}");
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

                                        if (use < 10 && use > 0)
                                        {
                                            use -= 1;
                                            Console.Clear();
                                            UI();
                                            useAsk = re.Ask($"You have selected Item : {inv[use].foodString}\r\nHealth Gain : {inv[use].healthGain}\r\nHunger Gain : {inv[use].hungerGain}\r\nSell Price : {(inv[use].price/2)}\r\n\r\nWould you like to sell this? [y]es or [n]o >");
                                            useAsk = useAsk.ToLower();
                                            if (useAsk == "y" || useAsk == "yes")
                                            {
                                                Console.WriteLine($"You sell the {inv[use].foodString} for ${(inv[use].price/2)}");
                                                pl.rupees += (inv[use].price/2);
                                                Console.ReadKey();

                                                inv[use] = new Inventory(0, 0, 0, "Blank", false);
                                                for (int i = use; i < 8; i++)
                                                {
                                                    inv[use] = inv[use + 1];
                                                    use++;
                                                }
                                                slotChecker--;
                                                if (slotChecker < 0)
                                                {
                                                    slotChecker = 0;
                                                }

                                            }
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Incorrect input");
                                            Console.ReadKey();
                                        }



                                        goBack = false;
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
                //If the player tries to quit with the q command, it saves all the values to texts files
                if (gameOn == false)
                {
                    Console.Clear();
                    Console.WriteLine("Saving...\r\nNow Exiting.");
                    StreamWriter writer;
                    //Makes new text file with the name
                    writer = new StreamWriter("pl.rupees.txt");
                    //fills text file
                    writer.WriteLine(pl.rupees);
                    //closes so the reader can read
                    writer.Close();

                    writer = new StreamWriter("pl.health.txt");
                    writer.WriteLine(pl.health);
                    writer.Close();

                    writer = new StreamWriter("pl.hunger.txt");
                    writer.WriteLine(pl.hunger);
                    writer.Close();

                    writer = new StreamWriter("currentWeapon.txt");
                    writer.WriteLine(currentWeapon);
                    writer.Close();

                    writer = new StreamWriter("currentDay.txt");
                    writer.WriteLine(currentDay);
                    writer.Close();

                    writer = new StreamWriter("pl.hunger.txt");
                    writer.WriteLine(pl.hunger);
                    writer.Close();

                    writer = new StreamWriter("slotChecker.txt");
                    writer.WriteLine(slotChecker);
                    writer.Close();

                    for (int i = 0; i <9; i++)
                    {
                    writer = new StreamWriter($"../../TextFiles/inv{i+1}.txt");
                    writer.WriteLine(inv[i].foodString);
                    writer.WriteLine(inv[i].healthGain);
                    writer.WriteLine(inv[i].hungerGain);
                    writer.Close();
                    }
                    break;
                }
                Console.Clear();
                UI();
                goalDay = 0;
                multiplierRupee = 0;
                goalDayAsked = "";
                //Asks players how many days they would like to work/sleep then assigns it to goalDayAsked and parses into goalDay Int
                goalDayAsked += re.Ask($"How many days would you like to sleep and work before returning to the shop? >");
                Int32.TryParse(goalDayAsked, out goalDay);
                // Run this loop for every day the player wanted to sleep/work
                for (int i = 0; i < goalDay; i++)
                {   //Reduce player hunger randomly between 0 loss and 1 loss of hunger
                    pl.hunger -= rd.Next(0, 2);
                    if (pl.health <= 0)
                    {
                        break;
                    }
                    //If the player has no more hunger, start hurting their health
                    if (pl.hunger < 1)
                    {
                        pl.hunger = 0;
                        pl.health -= (rd.Next(1,3));
                    }
                    //Multiplies current weapons preformance by a random int betwen 3 and 7 
                    //and then bumps up the current day.
                    multiplierRupee = (rd.Next(3, 7) * jobUpgradeArray[currentWeapon].jobUpgrade);
                    pl.rupees += multiplierRupee;
                    foundRupees += multiplierRupee;
                    currentDay++;
                }
                //If player health gets to low it kills them and ends the game
                if (pl.health <= 0)
                {
                    Console.Clear();
                    UI();
                    Console.WriteLine("You starved to death, nice job");
                    gameOn = false;
                    Console.ReadKey();
                    break;

                }
                //If the player reaches the end goal of the game (saving enough rupees to buy a house) it asks if they would like to win/end the game
                if (pl.rupees >= 50000)
                {
                    Console.Clear();
                    Console.WriteLine("You finally saved up the money to move to Cacirco Village! Congratulations!\r\nPress any key to continue >");
                    Console.ReadKey();
                    Console.Clear();
                    useAsk = re.Ask($"Would you like to purchase the house and end the game? [y]es? or [n]o?\r\nI reccomend quiting and saving in the shop menu first to save your progress! >");
                    if(useAsk == "y" || useAsk == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Congratulations, you moved out of your moms house and into your own and start your own adventure!\r\nPress any key to continue >");
                        Console.ReadKey();
                        gameOn = false;
                        break;
                    }
                }
                //Tells the player how many days passed and how many rupees they earned before returning to the shop.
                Console.Clear();
                UI();
                if (currentWeapon > 7)
                {
                    Console.WriteLine($"You work and sleep for {goalDay} days\r\nWith your {jobUpgradeArray[currentWeapon].jobUpgradeName} you destroyed the local landscape and found {foundRupees} Rupee dust shards\r\n\r\nPress Any Key To Continue >");
                }
                else
                {
                Console.WriteLine($"You work and sleep for {goalDay} days\r\nWith your {jobUpgradeArray[currentWeapon].jobUpgradeName} you mananged to get {foundRupees} Rupees\r\n\r\nPress Any Key To Continue >");
                }
                (petArray[petRandomizer]).HeadPat();
                multiplierRupee = 0;
                foundRupees = 0;
                goHome = false;
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
