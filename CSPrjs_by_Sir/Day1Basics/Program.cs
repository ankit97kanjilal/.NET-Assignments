using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take input from keyboard
            int num1, num2, result;

            Console.Write("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            //OR
            //num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter choice(1.ADD 2.SUBTRACT 3.MULTIPLY):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Sum:" + result);
            }
            else if (choice == 2)
            {
                result = num1 - num2;
                Console.WriteLine("Subtract:" + result);
            }
            else if(choice==3)
            {
                result = num1 * num2;
                Console.WriteLine("Multiply:" + result);
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }
    }
}
