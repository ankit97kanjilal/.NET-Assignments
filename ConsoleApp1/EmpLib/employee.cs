using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class employee
    {
        int empid;
        string ename;
        int salary;
        public employee() { }
        public employee(int id,string name, int s)//constructor
        {
            empid = id;
            ename = name;
            salary = s;
        }
        public string StoreEmployee(/*int id, string name, int s*/)
        {
            //empid = id;
            //ename = name;
            //salary = s;
            return "Hi I am in StoreEmployee from EMPLIBRARY..........";
        }
        public void CalculateBonus()
        {
            if(salary<5000)
                Console.WriteLine("No Bonus");
            else
                Console.WriteLine("Bonus is : " + salary*0.25);
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("Inside Display Employee");
        }
    }
}
