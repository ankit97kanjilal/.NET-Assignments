using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day5Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            N2.Order order = new N2.Order();


            //Few employees instances
            //Employee[] emps = new Employee[3];
            //emps[0] = new Employee { Ecode = 101, Ename = "Ravi" };
            //emps[1] = new Employee { Ecode = 102, Ename = "Rohit" };
            //emps[2] = new Employee { Ecode = 103, Ename = "Raman" };

            Employee emp = new Employee();
            //int ec = int.Parse(Console.ReadLine());
            emp[0, 101, "Ravi", 1111] = 0;
            emp[1, 102, "Rahul", 2222] = 0;
            emp[2, 103, "Raman", 3333] = 0;

            for (int i = 0; i < 3; i++)
            {
                emp.DisplayDetails(i);
            }




            Customer customer = new Customer();
            customer[0] = 1001;
            customer[1] = 1002;
            customer[2] = 1003;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(customer[i]);
            }
        }
    }

    class Employee
    {
        int[] ecode = new int[3];
        string[] ename = new string[3];
        int[] salary = new int[3];

        public int this[int i, int ecode,string ename,int salary]
        {
            set
            {
                this.ecode[i] = ecode;
                this.ename[i] = ename;
                this.salary[i] = salary;
            }
        }

        public void DisplayDetails(int i)
        {
            Console.WriteLine(ecode[i]+"\t"+ename[i]+"\t"+salary[i]);
        }
    }

    class Customer
    {
        int[] custid = new int[3];

        public int this[int i]
        {
            set
            {
                this.custid[i] = value;
            }
            get
            {
                return this.custid[i];
            }
        }
    }


    
}
namespace N2
{
    class Order
    {
        public void GetDetails()
        {
            //TODO
        }
    }
}

