using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExerciseFinal
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
            string num1;
            num1 = wr.Ask("Please write 5 numbers, starting with your First number >");
            int num1Out = 0;
            Int32.TryParse(num1, out num1Out);

            string num2;
            num2 = wr.Ask("Please write 5 numbers, starting with your Second number >");
            int num2Out = 0;
            Int32.TryParse(num2, out num2Out);

            string num3;
            num3 = wr.Ask("Please write 5 numbers, starting with your Third number >");
            int num3Out = 0;
            Int32.TryParse(num3, out num3Out);

            string num4;
            num4 = wr.Ask("Please write 5 numbers, starting with your Fourth number >");
            int num4Out = 0;
            Int32.TryParse(num4, out num4Out);

            string num5;
            num5 = wr.Ask("Please write 5 numbers, starting with your Fifth number >");
            int num5Out = 0;
            Int32.TryParse(num5, out num5Out);

            int[] data = new int[5] { num1Out, num2Out, num3Out, num4Out, num5Out };
            for (int i = 4; i > -1; --i)
            {
                Console.WriteLine(data[i]);
            }

            Console.ReadLine();
        }
    }

}
