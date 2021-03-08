using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            India india = new India();
            //india.SendMsgToAll();

            india.Test();
        }
    }


    class India
    {
        delegate int MathsDelegate(int n1, int n2);


        delegate void MessageDelegate(string msg); //declared 
        
        public void Test()
        {
            MathCls obj = new MathCls();
            MathsDelegate dlg = new MathsDelegate(obj.Add);
            int result = dlg(10, 20);
            Console.WriteLine("Sum:" + result);

            dlg = new MathsDelegate(obj.Subtract);
            result = dlg(10, 20);
            Console.WriteLine("Subtract:" + result);


            dlg = new MathsDelegate(obj.Multiply);
            result = dlg(10, 20);
            Console.WriteLine("Multiply:" + result);


            //dlg=new MathsDelegate (delegate (int n1, int n2)
            //                                {
            //                                    return n1 / n2;
            //                                });

            dlg = new MathsDelegate((n1,n2)=>{return n1 / n2;}); //lambda operator syntax
            result = dlg(50, 10);
            Console.WriteLine("Division:" + result);



        }
        
        public void SendMsgToAll()
        {
            string msg = "Hi, let us have peace everywhere";

            //initialize the delegate
            MessageDelegate dlg = new MessageDelegate(China.SendMsgToChina);
            //invoke the delegate
            //dlg(msg);
            //bind the other class method
            dlg += new MessageDelegate(Pakistan.SendMsgToPak); //Multi-cast delegate
            //invoke
            dlg(msg);



            //MessageDelegate d1 = new MessageDelegate(China.SendMsgToChina);
            //MessageDelegate d2 = new MessageDelegate(Pakistan.SendMsgToPak);

            //MessageDelegate d3 = d1 + d2;
            //d3(msg);
        }
    }
    class China
    {
        public static void SendMsgToChina(string msg)
        {
            Console.WriteLine("China:" + msg);
        }
    }
    class Pakistan
    {
        public static void SendMsgToPak(string msg)
        {
            Console.WriteLine("Pak:" + msg);
        }
    }
}

class MathCls
{
    public int Add(int n1,int n2)
    {
        return n1 + n2;
    }
    public int Subtract(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
}