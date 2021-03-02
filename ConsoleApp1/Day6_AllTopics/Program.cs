using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalAssemblyLib;

namespace Day6_AllTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackAndQueue();
            //HashSet();
            //SortedDictionary();
            GAC_deploy obj = new GAC_deploy();
            obj.getMsg();
        }
        static void StackAndQueue()
        {
            //Stack : follows the LIFO order
            Console.WriteLine("All about the Stacks.......");
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push(400);
            stack.Push(500);
            stack.Push(600);

            //dont use stack.Count() is the loop.. then by poping stack.Count() will get decreased
            //for (int i = 0; i < stack.Count; i++)
            int len = stack.Count();
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("By foreach loop......");
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push(400);
            stack.Push(500);
            stack.Push(600);

            foreach (int item in stack)
            {
                Console.WriteLine("Pop: " + item);
            }
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Peek: " + stack.Peek()); //Don't remove...
            //Console.WriteLine("Pop: " + stack.Pop());
            //Console.WriteLine("Pop: " + stack.Pop());   //Here Stack becomes empty....

            //Console.WriteLine("Pop: " + stack.Pop());   //System.InvalidOperationException: Stack empty....

            Console.WriteLine("");
            //Queue : follows the FIFO order
            Console.WriteLine("All about the Queue.......");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);
            queue.Enqueue(600);
            queue.Enqueue(700);

            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("DeQueue: " + queue.Dequeue());
            Console.WriteLine("DeQueue: " + queue.Dequeue());

        }
        static void HashSet()
        {
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(40);

            HashSet<int> hashSet2 = new HashSet<int>();
            hashSet2.Add(10);
            hashSet2.Add(20);
            hashSet2.Add(60);
            hashSet2.Add(70);

            hashSet.UnionWith(hashSet2);

            Console.WriteLine("HashSet items.......");
            foreach (int item in hashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("HashSet2 items.......");
            foreach (int item in hashSet2)
            {
                Console.WriteLine(item);
            }
        }
        static void SortedDictionary()
        {
            SortedDictionary<int, string> stDictionary = new SortedDictionary<int, string>();
            stDictionary.Add(10, "Ankit");
            stDictionary.Add(9, "Dipika");
            stDictionary.Add(7, "Amit");
            stDictionary.Add(3, "Bikram");
            stDictionary.Add(6, "Sumit");
            Console.WriteLine("SortedDictionary output........");
            foreach (int key in stDictionary.Keys)
            {
                Console.WriteLine(key + ":" + stDictionary[key]);
            }
        }
    }
}
