using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3OutAndRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 9000;
            double bonus = 0;
            Console.WriteLine("BEFORE: Salary:{0}\tBonus:{1}", salary, bonus);
            GetBonus(salary, out bonus);
            Console.WriteLine("AFTER: Salary:{0}\tBonus:{1}", salary, bonus);


            Employee emp = new Employee();
            emp.salary = 7000;
            emp.bonus = 0;
            Console.WriteLine("BEFORE: Salary:{0}\tBonus:{1}", emp.salary, emp.bonus);
            GetEmpBonus(emp);
            Console.WriteLine("AFTER: Salary:{0}\tBonus:{1}", emp.salary, emp.bonus);


        }

        static void GetEmpBonus(Employee emp)
        {
            if (emp.salary > 5000)
            {
                emp.bonus = 0.2 * emp.salary;
            }
        }
        static void GetBonus(int salary, out double bonus)
        {
            if (salary > 8000)
                bonus = 0.2 * salary;
            else
                bonus = 0.1 * salary;
        }
    }


    class Employee
    {
        public int salary;
        public double bonus;
    }
}
//ref:- is used when the modification is optional after passing the variable inside the method
//out:- is used when the modification is mandatory after passing the variable inside the method

