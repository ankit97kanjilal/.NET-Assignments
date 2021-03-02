using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total units of electricity: ");
            int unit = Convert.ToInt32(Console.ReadLine());
            double bill = 0;
            if(unit <= 200)
            {
                bill = Convert.ToDouble(unit * 0.5);
            }
            else if(unit>200 && unit <= 400)
            {
                bill = Convert.ToDouble(unit * 0.65);
            }
            else if(unit>400 && unit <= 600)
            {
                bill = Convert.ToDouble(unit * 0.8);
            }
            else if (unit > 600)
            {
                bill = Convert.ToDouble(unit * 1.0);
            }
            Console.WriteLine("Electricity bill is RS. "+bill);
        }
    }
}
