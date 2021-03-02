using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee.company = "ITC Infotech";

            Employee.SetCompany();

            Employee e1 = new Employee();
            e1.StoreData(101, "Ravi");
            Employee.DisplayCompany();

            Employee e2 = new Employee();
            e2.StoreData(102, "Rohit");
            Employee.DisplayCompany();

            Employee e3 = new Employee();
            e3.StoreData(103, "Rahul");
            Employee.DisplayCompany();

        }
    }

    class Employee
    {
        int ecode;
        string ename;
        static string company;

        public void StoreData(int ec, string en)
        {
            ecode = ec;
            ename = en;
            //company = "ITC Infotech";
            Console.WriteLine("\nData Assigned:{0}\t{1}", ecode, ename);
        }
        public static void SetCompany()
        {
            company = "ITC Infotech";
        }
        public static void DisplayCompany()
        {
            //Console.WriteLine("\nData Assigned:{0}\t{1}", ecode, ename); //non-static access not allowed
            Console.WriteLine("Company:" + company);
        }
    }
}

//static: is used to allocated and access fields and methods by using class name rather than 
//by each instances of the class.
//static methods can ONLY access static members(fields and methods) 
//non-static methods can access static members too
