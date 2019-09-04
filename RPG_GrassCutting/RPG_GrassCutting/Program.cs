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

        static void Main(string[] args)
        {
            //Food pz = new Pizza(); 
            //Food lt = new Lettuce();
            //Food ap = new Apple();
            Food fd = new Food(1); // 1 2 or 3 for each case

            Food pz1 = new Food(1, 2, 3, 4, ($"Pizza \r\n" +
                         $"Price : {fd.price} \r\n" + //THIS RIGHT HERE THIS WORKS
                         $"Quanity : {22} \r\n" +
                         $"Health Gain : {33} \r\n" +
                         $"Hunger Gain : {44}"));
            Food lt1 = new Food(1, 2, 3, 4, "lettuce");
            Food ap1 = new Food(1, 2, 3, 4, "apple");

            string[] foodFix = new string[4];
            //foodFix[0] = pz.foodString[0];
            //foodFix[1] = lt.foodString[0];
            //foodFix[2] = ap.foodString[0];

            //Console.WriteLine($"{pz.foodString[0]} \r\n {lt.foodString[1]} \r\n {ap.foodString[2]} ");
            //Console.WriteLine($"{foodFix[0]} \r\n \r\n{foodFix[1]} \r\n \r\n{foodFix[2]}");
            Console.WriteLine(pz1.foodString[0]);
            Console.ReadKey();
        }
    }
}
