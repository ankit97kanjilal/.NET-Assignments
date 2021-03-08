using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Debugging
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);    //9990
            }




            int salary = 7000;
            double bonus;
            Employee emp = new Employee();
            bonus = emp.GetBonus(salary);
            Console.WriteLine("Salary:{0}\tBonus:{1}",salary,bonus);

            salary = 4000;
            bonus = emp.GetBonus(salary);
            Console.WriteLine("Salary:{0}\tBonus:{1}", salary, bonus);
        }
    }

    class Employee
    {

        public double GetBonus(int salary)
        {
            double bonus = 0;
            if(salary>5000)
            {
                bonus = 0.1 * salary;
            }
            else
            {
                bonus = 0.2 * salary;
            }

            return bonus;
        }

    }
}
