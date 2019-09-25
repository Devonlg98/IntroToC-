using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trig
{
    class Program
    {


        static void Main(string[] args)
        {
            float degree2Radian(float x)
        {
            float result = (x * ((float)Math.PI / 180f)); 
            return result;
        }

        float radian2Degree(float x)
        {
            float result = 57.2958f/x;
            return result;
        }

            float answerAskFloat = 0f;

            Console.WriteLine("Would you like to convert [d]egrees to radians or [r]adians to degrees?");
            string answerAsk = Console.ReadLine();

            switch (answerAsk)
            {
                case "d":
                    Console.WriteLine("Input your degree >");
                    answerAsk = Console.ReadLine();
                    answerAskFloat = float.Parse(answerAsk);
                    Console.WriteLine(degree2Radian(answerAskFloat));
                    Console.ReadKey();

                    break;

                case "r":
                    Console.WriteLine("Input your radian >");
                    answerAsk = Console.ReadLine();
                    answerAskFloat = float.Parse(answerAsk);
                    Console.WriteLine(radian2Degree(answerAskFloat));
                    Console.ReadKey();
                    break;

            }
        }
    }
}
