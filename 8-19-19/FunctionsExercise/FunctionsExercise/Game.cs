using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercise
{
    class Game
    {
        int score =0;
        public void PrintScore()
        {
            AddToScore(1);
            AddToScore(5);
            AddToScore(999);
        }

        private int AddToScore(int add)
        {
            score += add;
            Console.WriteLine("You have scored, your current score is " + score + ".");
            return score;
        }
    }
}
