using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Generics
{
    class Employee : IComparable<Employee>
    {
        public int Ecode { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }
        public int Deptid { get; set; }

        public int CompareTo(Employee other)
        {
            if(this.Salary>other.Salary)
            {
                return -1;
            }
            else if(this.Salary<other.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
