using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7CallbackDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager();
            mgr.InitiateTaskOnEmployee();
        }
    }


    class Manager
    {
        string notificationMsg;

        public void InitiateTaskOnEmployee()
        {
            Console.WriteLine("Task initiated");
            Employee emp = new Employee();
            emp.dlg = new Employee.CallbackDelegate(this.Notify);
            emp.DoTask();
        }
        void Notify(string msg)
        {
            notificationMsg = msg;
            Console.WriteLine(notificationMsg);
        }
    }


    class Employee
    {
        public delegate void CallbackDelegate(string msg);
        public CallbackDelegate dlg = null;
        public void DoTask()
        {
            Console.WriteLine("Task is running");
            dlg("Task is completed");
        }
    }
}
