using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestValue
{
    public class Program
    {

        public void LargestNumber(int[] num)
        {

            int largNum = 0;
            int[] numbers = new int[6] { 52, -1, 55, 100, 17, 8 };
            for(int i = 0; i < 6; i++)
            {
                if(numbers[i] > largNum)
                {
                    largNum = numbers[i];
                }
            }
            return largNum;
        }
    }
}
