using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3arraygrid
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

            string foodAmt;
            int dayCounter = 0;
            int drgSlider = 0;
            int arraySlider = 1;
            int[,] map = new int[3, 7];
            for(int rowDragon = 0; rowDragon < 3; rowDragon++)
            {
                for (int colDay = 0; colDay < 7; ++colDay)
                {
                    foodAmt = wr.Ask($"How many small children is {drgNames[drgSlider]} going to eat for day {dayCounter}?");
                    int foodAmtOut = 0;
                    Int32.TryParse(foodAmt, out foodAmtOut);
                    map[rowDragon, colDay] = foodAmtOut;
                    arraySlider++;
                    dayCounter++;
                }
                Console.WriteLine($"Dragon {drgNames[drgSlider]} {map[rowDragon, 0]} {map[rowDragon, 1]} {map[rowDragon, 2]} {map[rowDragon, 3]} {map[rowDragon, 4]} {map[rowDragon, 5]} {map[rowDragon, 6]}");
                drgSlider++;
                dayCounter = 0;
            }
            Console.ReadKey();
        }
    }
}
