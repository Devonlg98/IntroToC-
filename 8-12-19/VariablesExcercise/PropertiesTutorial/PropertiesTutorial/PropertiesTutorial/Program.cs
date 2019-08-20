using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTutorial
{
    class TimePeriod
    {
        private int days;
        public int Days
        {
            get
            {
                return days;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine(time.Days);
        }
    }
}
