using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test obj = new Test();
            //obj.Add(10, 20);
            //obj.Add("Hello ", "World");

            Console.WriteLine("Static binding");
            Parent obj2 = new Parent();
            obj2.Show();
            Child obj3 = new Child();
            obj3.Show();

            Console.WriteLine("\nDynamic binding");
            Parent obj;

            obj = new Parent();
            obj.Show();

            obj = new Child();
            obj.Show();
        }
    }

    class Test
    {
        public void Add(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Sum:" + result);
        }
        public void Add(string s1,string s2)
        {
            string s3 = s1 + s2;
            Console.WriteLine("String:" + s3);
        }
    }


    class Abc
    {
        public override string ToString()
        {
            return "";
        }
    }




    class Parent
    {
        public void Method1Parent()
        {

        }
        public virtual void Show()
        {
            Console.WriteLine("Parent-Show");
        }
    }

    class Child : Parent
    {
        public override void Show()
        {            
            Console.WriteLine("Child-Show");
        }
        public void Method2Child()
        {

        }
    }
}
