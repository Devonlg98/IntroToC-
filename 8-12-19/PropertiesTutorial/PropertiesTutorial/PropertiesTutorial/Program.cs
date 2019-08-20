using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTutorial
{
    class Money
    {
        public float aud;
        public float usd;
        public float Usd
        {
            get // multipies the value of aud by 0.68
            {
                return (0.68f / 1f) * aud;
            }
            set // set the value of usd
            {
                aud = (1f / 0.68f) * value;
            }
        }
      
       // public float myMoney = 50;

        //public float MyMoney
        //{
        //    get
        //    {
        //        return myMoney;
        //    }

        //    set
        //    {
        //        aud = value * (1f/0.68f);
        //    }
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Money aud = new Money();
            //Console.WriteLine(aud.myMoney);
            Money myMoney = new Money();
            myMoney.aud = 40;
            string displayAud = myMoney.aud + " AUD equals " + myMoney.Usd + " USD.";

            Console.WriteLine(displayAud);
            Console.ReadKey();
        }
    }
}