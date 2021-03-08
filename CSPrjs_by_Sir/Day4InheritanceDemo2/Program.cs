using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Child ch = new Child(200, 100);
            ch.Display_P();
            ch.Display_C();
        }
    }


    //constructor chaining 

    class Parent
    {
        private int p;
        protected int var_pro=50;
        public Parent(int p)
        {
            this.p = p;
        }
        public void Display_P()
        {
            Console.WriteLine("Parent P:" + p);
        }
    }
    class Child : Parent
    {
        int c;
        public Child(int c,int p) : base(p)
        {
            
            this.c = c;
        }
        public void Display_C()
        {
            Console.WriteLine("Parent Pro:"+ var_pro);
            Console.WriteLine("Child C:" + c);
        }
    }

}

//only protected and public members will get accessed thru inheritance inside the class.
//public members can also be accessed outsid the class but protected member only in the child not outside the class


