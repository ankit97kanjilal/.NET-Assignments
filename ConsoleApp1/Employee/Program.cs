using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpLib;// using the emplibrary here

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee(100, "Ankit", 15000);
            Console.WriteLine(e.StoreEmployee());
            e.CalculateBonus();
            e.DisplayEmployee();
        }
    }
}
