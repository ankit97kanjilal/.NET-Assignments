using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ConstAndReadonly
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test(100);
        }
    }

    class Test
    {
        const double PI = 3.14;
        readonly int var_r;

        public Test(int data)
        {
            var_r = data;
        }

        public void SetData(int data)
        {
            //var_r = data;  //invalid
        }

    }
}

//const:- cannot be modified at runtime, its value is fixed during declaration itself
//readonly : can be assigned data at runtime ONLY thru constructor not in any other method

