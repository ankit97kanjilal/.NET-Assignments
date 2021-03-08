using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            //obj.Divide();


            try
            {
                obj.DoTask();
            }
            catch(Exception ex)
            {
                if(ex.InnerException!=null)
                    Console.WriteLine(ex.InnerException.Message);

                Console.WriteLine(ex.Message);
            }


        }
    }

    class Test
    {
        public void Divide()
        {
            try
            {
                int n1, n2, result;
                Console.Write("Enter N1:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter N2:");
                n2 = int.Parse(Console.ReadLine());
                //if (n2 == 0)
                //{
                    result = n1 / n2;
                    Console.WriteLine("Result:" + result);
                //}
                //else
                //{
                //    Console.WriteLine("Denominator must not be 0");
                //}
            }
            catch (DivideByZeroException ex)
            {
                //TODO
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Have a good day");
            }
        }


        public void DoTask()
        {
            try
            {
                int n1 = 10, n2 = 0, result;
                result = n1 / n2;
                Console.WriteLine("Result:" + result);
            }
            catch (DivideByZeroException ex)
            {
                //log the error in some log file for analysis

                //To create a file and save the exception in it
                throw new InvalidOperationException("u don't have permission to write to this file",ex);

            }
        }


        ~Test()
        {
            Console.WriteLine("Destructor executed");
        }
    }
}
