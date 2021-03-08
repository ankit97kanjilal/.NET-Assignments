using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();

            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(40);

            HashSet<int> hasSet2 = new HashSet<int>();
            hasSet2.Add(10);
            hasSet2.Add(60);
            hasSet2.Add(70);

            hashSet.IntersectWith(hasSet2);

            foreach (int item in hashSet)
            {
                Console.WriteLine(item);
            }


            //ListDemo();
            //DictionaryDemo();
            //ListDemo2();
            //StackAndQueue();
            SortedDictionaryDemo();
        }
        static void ListDemo()
        {
            List<int> lstNum = new List<int>();

            lstNum.Add(20);
            lstNum.Add(10);
            lstNum.Add(30);
            lstNum.Add(50);
            lstNum.Add(40);

            //SortByDesc descSort = new SortByDesc();
            lstNum.Sort();

            Console.WriteLine("Using for-index");
            for (int i = 0; i < lstNum.Count; i++)
            {
                Console.WriteLine(lstNum[i]);
            }

            Console.WriteLine("\nUsing foreach");
            foreach (int item in lstNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nUsing IEnumerator<>");
            IEnumerator<int> ien = lstNum.GetEnumerator();   //which implements IEnumerable<>
            while(ien.MoveNext())
            {
                int item =ien.Current;
                Console.WriteLine(item);
            }



        }
       
        static void DictionaryDemo()
        {
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(1001, "Learning C#");
            books.Add(1002, "ASP.NET for Beginners");
            books.Add(1003, "ADO.NET Deep dive");           

            Console.WriteLine(books[1001]);
            Console.WriteLine(books[1002]);
            Console.WriteLine(books[1003]);

            //books.Remove(1003);

            foreach (int k in books.Keys)
            {
                Console.WriteLine(k + ":" + books[k]);
            }

            foreach (string v in books.Values)
            {
                Console.WriteLine(v);
            }
        }

        static void ListDemo2()
        {
            List<Employee> lstEmps = new List<Employee>();
            lstEmps.Add(new Employee { Ecode = 101, Ename = "Ravi", Salary = 2222, Deptid = 201 });
            lstEmps.Add(new Employee { Ecode = 102, Ename = "Rahul", Salary = 1111, Deptid = 202 });
            lstEmps.Add(new Employee { Ecode = 103, Ename = "Rohit", Salary = 3333, Deptid = 202 });
            lstEmps.Add(new Employee { Ecode = 104, Ename = "David", Salary = 5555, Deptid = 203 });
            lstEmps.Add(new Employee { Ecode = 105, Ename = "Iyan", Salary = 4444, Deptid = 201 });

            SortByEcode sortByEc = new SortByEcode();
            lstEmps.Sort(sortByEc);


            Console.WriteLine("\nusing foreach");
            foreach (Employee e in lstEmps)
            {
                Console.WriteLine(e.Ecode+"\t"+e.Ename+"\t"+e.Salary+"\t"+e.Deptid);
            }

            Console.WriteLine("\nusing IEnumerator<>");
            IEnumerator<Employee> ien = lstEmps.GetEnumerator();
            while(ien.MoveNext())
            {
                Employee emp = ien.Current;
                Console.WriteLine(emp.Ecode + "\t" + emp.Ename + "\t" + emp.Salary + "\t" + emp.Deptid);
            }

        }

        static void StackAndQueue()
        {
            Console.WriteLine("STACK");
            //LIFO : Last-In-First-Out
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push(400);
            stack.Push(500);

            //int len = stack.Count;

            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            

            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Peek:" + stack.Peek());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Peek:" + stack.Peek());
            Console.WriteLine("Pop:" + stack.Pop());
            Console.WriteLine("Pop:" + stack.Pop());



            Console.WriteLine("\nQUEUE");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);

            Console.WriteLine("DeQueue:" + queue.Dequeue());
            Console.WriteLine("DeQueue:" + queue.Dequeue());
            Console.WriteLine("DeQueue:" + queue.Dequeue());
            Console.WriteLine("Peek:" + queue.Peek());
            Console.WriteLine("DeQueue:" + queue.Dequeue());
            Console.WriteLine("Peek:" + queue.Peek());
            Console.WriteLine("DeQueue:" + queue.Dequeue());


          
        }

        static void SortedDictionaryDemo()
        {
            SortedDictionary<int, string> books = new SortedDictionary<int, string>();
            books.Add(1, "Book1");
            books.Add(3, "Book3");
            books.Add(2, "Book2");
            books.Add(5, "Book5");
            books.Add(4, "Book4");


            foreach (int k in books.Keys)
            {
                Console.WriteLine(k + ":" + books[k]);
            }

        }
    }

    class SortByDesc : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if(x<y)
            {
                return 1;
            }
            else if(x>y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class SortByEcode : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if(x.Ecode>y.Ecode)
            {
                return -1;
            }    
            else if(x.Ecode<y.Ecode)
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
