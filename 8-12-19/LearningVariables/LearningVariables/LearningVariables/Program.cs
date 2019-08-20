using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    class Program
    {
        static void Main()
        {

            int gameScore = 0;
            string winState = "You win, Your highscore is: " + gameScore + ".";
            String displayWinState = winState;

            Console.WriteLine(displayWinState);
            Console.ReadKey();
        }
    }
}
