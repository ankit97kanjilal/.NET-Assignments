using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000;
            int interest = 5;
            int sum = amount*(100 + interest) / 100;
            Console.WriteLine(" after 1 year sum is : " + sum);
            int year = 1;
            while(sum < 1000000)
            {
                sum= sum* (100 + interest) / 100;
                Console.WriteLine("amount after year end is : " +sum);
                year++;
            }
            Console.WriteLine("Year needed is : "+year);
            //Console.WriteLine(" Sum is : "+sum);
        }
    }
}
