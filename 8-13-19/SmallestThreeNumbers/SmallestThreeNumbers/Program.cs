using System;

namespace SmallestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your first number");
            String num1 = Console.ReadLine();
            int num1a = 0;
            Int32.TryParse(num1, out num1a);
            Console.WriteLine("Please write your second number");
            String num2 = Console.ReadLine();
            int num2a = 0;
            Int32.TryParse(num2, out num2a);
            Console.WriteLine("Please write your third number");
            String num3 = Console.ReadLine();
            int num3a = 0;
            Int32.TryParse(num3, out num3a);
            int lowNum = 0;


            
            if (num1a < num2a && num1a < num3a)
            {
                lowNum = num1a;
            }
            else if (num2a < num1a && num2a < num3a)
            {
                lowNum = num2a;
            }
            else if (num3a < num1a && num3a < num2a)
            {
                lowNum = num3a;
            }

            Console.WriteLine("The lowest number you typed is: " + lowNum + ".");
            Console.ReadLine();
        }
    }

}
