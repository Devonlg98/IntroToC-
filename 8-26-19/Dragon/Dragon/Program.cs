using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon
{
    class Write
    {
        public string Ask(string _val)
        {
            Console.WriteLine(_val);
            return Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write wr = new Write();
            string drg1;
            string drg2;
            string drg3;
            drg1 = wr.Ask("Please name Dragon 1 >");
            drg2 = wr.Ask("Please name Dragon 2 >");
            drg3 = wr.Ask("Please name Dragon 3 >");
            string[] drgNames = new string[3] { drg1, drg2, drg3 };
            float[] avgFoodDrg = new float[3];

            int smallBoi = 0;
            int bigBoi = 0;
            int largNum = 0;
            int smallNum = 0;
            float avgFoodDrgSld = 0;
            float avgFood = 0;
            string foodAmt;
            int dayCounter = 0;
            int drgSlider = 0;
            int arraySlider = 1;
            int[,] map = new int[3, 7];
            for (int rowDragon = 0; rowDragon < 3; rowDragon++)
            {
                for (int colDay = 0; colDay < 7; ++colDay)
                {
                    foodAmt = wr.Ask($"How many small children is {drgNames[drgSlider]} going to eat for day {dayCounter +1}?");
                    int foodAmtOut = 0;
                    Int32.TryParse(foodAmt, out foodAmtOut);
                    smallNum = map[0, 0];
                    map[rowDragon, colDay] = foodAmtOut;
                    avgFood += foodAmtOut;
                    avgFoodDrgSld += foodAmtOut;
                    arraySlider++;
                    dayCounter++;
                    if (foodAmtOut > largNum)
                    {
                        largNum = foodAmtOut;
                        bigBoi = drgSlider;
                    }
                    if (foodAmtOut < smallNum)
                    {
                        smallNum = foodAmtOut;
                        smallBoi = drgSlider;
                    }

                }
                avgFoodDrg[rowDragon] = avgFoodDrgSld;
                avgFoodDrgSld = 0;
                Console.WriteLine($"Dragon {drgNames[drgSlider]} {map[rowDragon, 0]} {map[rowDragon, 1]} {map[rowDragon, 2]} {map[rowDragon, 3]} {map[rowDragon, 4]} {map[rowDragon, 5]} {map[rowDragon, 6]}");
                drgSlider++;
                dayCounter = 0;

            }
            avgFood /= 21;
            avgFoodDrg[0] /= 7;
            avgFoodDrg[1] /= 7;
            avgFoodDrg[2] /= 7;
            Console.WriteLine($"The average amount of food eaten per day by all dragons is {avgFood}");
            Console.WriteLine($"The average amount of food eaten per day by {drgNames[0]} is {avgFoodDrg[0]}");
            Console.WriteLine($"The average amount of food eaten per day by {drgNames[1]} is {avgFoodDrg[1]}");
            Console.WriteLine($"The average amount of food eaten per day by {drgNames[2]} is {avgFoodDrg[2]}");
            Console.WriteLine($"The smallest amount of food eaten in a day was {smallNum} by {drgNames[smallBoi]}.");
            Console.WriteLine($"The largest amount of food eaten in a day was {largNum} by {drgNames[bigBoi]}.");
            Console.ReadKey();
        }
    }
}
