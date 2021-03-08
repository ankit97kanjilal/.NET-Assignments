using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalAssemblyLib;

namespace CallingGACAssemblyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GACCls obj = new GACCls();
            Console.WriteLine(obj.GetMsg());
            Console.WriteLine(obj.GetData());
        }
    }
}
