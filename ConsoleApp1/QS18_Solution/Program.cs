//Create a project with following one interface and two classes:
//1) Interest: has a method "CalculateInterest" accepting three 	parameters "principal","rate" and "years". 
//Implement this interface     in the following two classes:
//2) SimpleInterest: has the overridden method "CalculateInterest" as 	per simple interest 
//formula "(P*R*T)/100" and returns the interest	value.
//3) CompoundInterest: has the overridden method "CalculateInterest" as 	per compound interest 
//formula "P*(1+R/100)^T" and returns the interest value.	 

//[Hint: Math.Pow(x, y) can be used for power function]	
//•Use these classes which takes input of the three data "principal","rate" and "years" and asks user which interest(SI or CI) is needed and hence displays the corresponding interest value.
//Note:
//	-You have to use only one object throughout. 

//[Hint: Use Dynamic Polymorphism]


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS18_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Interest si;
            Console.Write("Enter the priciple: ");
            double principle = double.Parse(Console.ReadLine());
            Console.Write("Enter the rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter the years: ");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the Option...\n 1.Simple Interest\t2.Coumpound Interst");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                si = new SimpleInterest();
                si.CalculateInterest(principle, rate, years);
            }
            else if (choice == 2)
            {
                si = new CompoundInterest();
                si.CalculateInterest(principle, rate, years);
            }
            else
                Console.WriteLine("Wrong Choice");

        }
        interface Interest
        {
            void CalculateInterest(double principal,double rate,int years);
        }
        class SimpleInterest:Interest
        {
            public void CalculateInterest(double principal, double rate, int years)
            {
                double interest = principal * (rate * years) / 100;
                Console.WriteLine("The Interest rate is : "+interest);
            }
        }
        class CompoundInterest:Interest
        {
            public void CalculateInterest(double principal, double rate, int years)
            {
                double interest = principal *Math.Pow((1 + rate / 100), years) - principal; //P*(1+R/100)^T
                Console.WriteLine("The Interest rate is : " + interest);
            }
        }

    }
}
