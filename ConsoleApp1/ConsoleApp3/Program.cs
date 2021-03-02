using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine((int)MenuChoice.ADD); //starting default value is 0
            //next item value is one greater than the previous item value

            int result = 0;
            Console.WriteLine("1.ADD");
            Console.WriteLine("2.SUBTRACT");
            Console.WriteLine("3.MULTIPLY");
            Console.WriteLine("4.DIVIDE");
            Console.WriteLine("5.EXIT");
            Console.Write("Enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter n1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)MenuChoice.ADD:
                    result = n1 + n2;
                    Console.WriteLine("Sum:" + result);
                    break;
                case (int)MenuChoice.SUBTRACT:
                    result = n1 - n2;
                    Console.WriteLine("Difference:" + result);
                    break;
                case (int)MenuChoice.MULTIPLY:
                    result = n1 * n2;
                    Console.WriteLine("Product:" + result);
                    break;
                case (int)MenuChoice.DIVIDE:
                    result = n1 / n2;
                    Console.WriteLine("Division:" + result);
                    break;
                case (int)MenuChoice.EXIT:
                    Console.WriteLine("Exited...");
                    break;
                default:
                    Console.WriteLine("invalid choice:");
                    break;
            }
        }
    }

    enum MenuChoice
    {
        ADD = 1,
        SUBTRACT,
        MULTIPLY,
        DIVIDE,
        EXIT
    }
}
