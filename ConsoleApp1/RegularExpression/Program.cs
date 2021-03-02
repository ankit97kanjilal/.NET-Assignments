using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ankit";
            if (Regex.IsMatch(name, @"^ [a - z]* $"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
