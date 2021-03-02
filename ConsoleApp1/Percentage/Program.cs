using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Percentage: ");
            int m = Convert.ToInt32(Console.ReadLine());
            string division = "";
            if (m >= 60)
                division = "first";
            else if (m > 50 && m < 60)
                division = "second";
            else if (m > 40 && m < 50)
                division = "third";
            else
                division = "fail";
            Console.WriteLine("The division of the student is : " + division);
        }
    }
}
