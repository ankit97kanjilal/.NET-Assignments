using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS12_Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            int TA = 0;
            while (1>0)
            {
                Console.WriteLine("Enter 'y' to entry for products: ");
                char ch = Convert.ToChar(Console.ReadLine());
                int i = 1;
                int amount = 0;
                if (ch == 'y')
                {
                    Console.WriteLine("Enter Details of the item number: " + i++);
                    
                    Console.Write("Enter the item code: ");
                    Console.ReadLine();
                    
                    Console.Write("Enter the item qty: ");
                    int qty = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("Enter the price for each item: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    
                    amount += price * qty;
                    TA += amount;
                    
                    Console.WriteLine("Total price : " + amount);
                    Console.WriteLine("Total Effective Price : " + TA);
                }
                else
                    break;
            }
            if (TA > 10000)
            {
                Console.WriteLine("You are allowed for 10% discount");
                Console.WriteLine("Now Total Effective Price is : " + TA * 0.9);
            }
            else if (TA < 1000)
            {
                Console.WriteLine("Paying Options : 1.CASH  2.CARD");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 2)
                {
                    Console.WriteLine("surcharge of 2.5% is levied on the grand total...");
                    Console.WriteLine("Now Total Effective Price is : " + TA * 102.5 / 100);
                }
            }
            else
            {
                Console.WriteLine("Thank you for Shopping... \n" +
                    "If you buy more products of RS. "+ (10000-TA) + " then you will get 10% discount on total purchases");
                Console.WriteLine("Now Total Effective Price is : " + TA);
            }
        }
    }
}
