using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Day5ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Hashtable ht = new Hashtable();
            //ht.Add("username", "Administrator");
            ht.Add("password", "admin@123");
            ht.Add("server", "localhost");

            //Console.WriteLine(ht["username"].ToString());
            Console.WriteLine(ht["password"].ToString());
            Console.WriteLine(ht["server"].ToString());

           

            if (ht.ContainsKey("username"))
            {
                Console.WriteLine("username already added");
            }
            else
            {
                ht.Add("username", "Guest");
            }

            //ht["username"] = "Guest";
            Console.WriteLine(ht["username"].ToString());

            IEnumerator ien = ht.Values.GetEnumerator();
            while(ien.MoveNext())
            {
                string item = ien.Current.ToString();
                Console.WriteLine(item);
            }

        }
        static void ArrayListDemo()
        {
            ArrayList arrLst = new ArrayList();
            arrLst.Add("AAA");
            arrLst.Add("BBB");
            arrLst.Add(100);
            arrLst.Add(16.5);

            Console.WriteLine("Using for-index");
            for (int i = 0; i < arrLst.Count; i++)
            {
                Console.WriteLine(arrLst[i].ToString());
            }

            Console.WriteLine("\nUsing for-each");
            foreach (object item in arrLst)
            {
                if (item is int)
                {
                    int val = (int)item;
                    Console.WriteLine(val);
                }
                if (item is string)
                {
                    string s = item.ToString();
                    Console.WriteLine(s);
                }
            }
        }
    }
}
