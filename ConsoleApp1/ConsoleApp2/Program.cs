using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000;
            double rate = 1.5;
            double sum = amount;
            //sum = sum - 100;
            int m = 0;
            while(sum>0)
            {
                sum = sum * (100 + rate) / 100;
                sum -= 100;
                m++;
                Console.WriteLine("remaining: " + sum);
            }

            Console.WriteLine("month needed : " + m);
        }
    }
}
