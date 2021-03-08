using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Ecode = 101;
            //emp.Ename = "Ravi";
            //emp.Salary = 1111;
            //emp.Deptid = 201;

            //Object initializer syntax
            Employee emp = new Employee 
            { 
                Ecode = 101, 
                Ename = "Ravi", 
                Salary = 1111, 
                Deptid = 201 
            };


            Console.WriteLine(emp.Ecode +"\t"+ emp.Ename+"\t"+emp.Salary+"\t"+emp.Deptid+"\t"+emp.GetBonus());
        }
    }

    class Employee
    {
        public int Ecode { get; set; } //generates one private field and two get/set methods autimatically
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        public double GetBonus()
        {
            double bonus = Ecode * 0.1;
            return bonus;
        }
    }
}
