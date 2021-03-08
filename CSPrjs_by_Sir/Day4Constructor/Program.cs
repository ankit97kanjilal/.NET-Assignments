using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter DOB:");
            DateTime dob2 = DateTime.ParseExact(Console.ReadLine(),"MM-dd-yyyy",null);



            Console.WriteLine(dob2);




            DateTime dob = new DateTime(1978, 05, 15);
            DateTime currentDate = DateTime.Now; //current local system date and time

            Console.WriteLine(dob.ToString("dd-MM-yyyy"));
            Console.WriteLine(currentDate.ToString("dd-MM-yyyy"));

            Console.WriteLine(currentDate.ToString("yyyy"));
            Console.WriteLine(currentDate.ToString("MM"));

            int m = currentDate.Month;

            int m2 = int.Parse(currentDate.ToString("MM"));


            Employee e1 = new Employee(101, "Ravi","ITC");
            Employee e2 = new Employee(102, "Ram", "ITC");

            Employee e3 = new Employee();

            //GC.Collect() forced garbage collection irespective of generations

            //GC.SuppressFinalize(e3); //suppress finalize(destructor) method calling


        }

        public void SetData(DateTime dt)
        {

        }
    }


    class Employee
    {

        int ecode;
        string ename;
        string company;

        public Employee() { }
        public Employee(int ecode, string ename, string company)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.company = company;

            Console.WriteLine("Non-static ctor called");
        }

        public Employee(int ecode,  string company)
        {
            this.ecode = ecode;            
            this.company = company;

            Console.WriteLine("Non-static ctor called");
        }
        //static Employee()
        //{
        //    company = "ITC";
        //    Console.WriteLine("Static ctor called");
        //}


        ~Employee()
        {
            Console.WriteLine("destructor is called");
        }

    }
}
