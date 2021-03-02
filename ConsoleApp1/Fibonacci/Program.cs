using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = a + b;
            Console.Write(a+" "+b);
            while(c < range)
            {
                Console.Write(" "+c);
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine("");
        }
    }
}
