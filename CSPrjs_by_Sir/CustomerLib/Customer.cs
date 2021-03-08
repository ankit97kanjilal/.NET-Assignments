using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public class Customer
    {
        int custid;
        string cname;
        string city;

        protected internal int var_pro_inrnl = 10; //becomes protected for outside and public here
        internal int var_intrnl = 20; //becomes private for outside and public here

        public void StoreDetails(int cid,string cn, string custCity)
        {
            custid = cid;
            cname = cn;
            city = custCity;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(custid+"\t"+cname+"\t"+city);
        }
    }
}
