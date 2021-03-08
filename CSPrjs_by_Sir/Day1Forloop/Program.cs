using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Forloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, product;

            Console.Write("Enter any number:");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++ )
            {
                product = num * i;
                //Console.WriteLine(num + "x" + i + "=" + product);
                //OR
                Console.WriteLine("{0}x{1}={2}", num, i, product);

            }
        }
    }
}
