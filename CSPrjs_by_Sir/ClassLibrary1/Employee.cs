using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        int ecode;
        string ename;
        int salary;

        public void StoreEmployee(int ec,string en, int sal)
        {
            ecode = ec;
            ename = en;
            salary = sal;
        }
    }
}
