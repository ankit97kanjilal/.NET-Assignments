using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITC;
using ITC.Blr;
using ITC.Hyd;

namespace Day5NMSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hr hr = new Hr();
            Console.WriteLine(hr.GetMsg());

            Employee emp = new Employee();
            Console.WriteLine(emp.GetMsg());

            Account account = new Account();
            Console.WriteLine(account.GetMsg());

            Admin admin = new Admin();
            Console.WriteLine(admin.GetMsg());
        }
    }
}
namespace ITC
{
    public class Hr
    {
        public string GetMsg()
        {
            return "ITC.HR.GetMsg";
        }
    }
    namespace Blr
    {
        public class Employee
        {
            public string GetMsg()
            {
                return "ITC.Blr.Employee.GetMsg";
            }
        }
    }
    namespace Hyd
    {
        public class Account
        {
            public string GetMsg()
            {
                return "ITC.Hyd.Account.GetMsg";
            }
        }
    }
}